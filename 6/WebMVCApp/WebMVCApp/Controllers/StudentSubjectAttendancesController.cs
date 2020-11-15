using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using WebMVCApp.Models;
using System.Collections.Generic;

namespace WebMVCApp.Controllers
{
    public class StudentSubjectAttendancesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentSubjectAttendances
        public async Task<ActionResult> Index()
        {
            List<StudentSubjectAttendance> attendances = await db.Attendance.ToListAsync();
            foreach (StudentSubjectAttendance attendance in attendances)
            {
                attendance.Student = await db.Students.FindAsync(attendance.StudentId);
                attendance.Subject = await db.Subjects.FindAsync(attendance.SubjectId);
            }
            return View(attendances);
        }

        // GET: StudentSubjectAttendances/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectAttendance attendance = await db.Attendance.FindAsync(id);
            if (attendance == null)
            {
                return HttpNotFound();
            }

            attendance.Student = await db.Students.FindAsync(attendance.StudentId);
            attendance.Subject = await db.Subjects.FindAsync(attendance.SubjectId);

            return View(attendance);
        }

        // GET: StudentSubjectAttendances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentSubjectAttendances/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,StudentId,SubjectId,CountOfMisses")] StudentSubjectAttendance attendance)
        {
            if (ModelState.IsValid)
            {
                attendance.Id = Guid.NewGuid();
                db.Attendance.Add(attendance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(attendance);
        }

        // GET: StudentSubjectAttendances/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectAttendance attendance = await db.Attendance.FindAsync(id);
            if (attendance == null)
            {
                return HttpNotFound();
            }
            return View(attendance);
        }

        // POST: StudentSubjectAttendances/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,StudentId,SubjectId,CountOfMisses")] StudentSubjectAttendance attendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(attendance);
        }

        // GET: StudentSubjectAttendances/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentSubjectAttendance attendance = await db.Attendance.FindAsync(id);
            if (attendance == null)
            {
                return HttpNotFound();
            }
            return View(attendance);
        }

        // POST: StudentSubjectAttendances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            StudentSubjectAttendance attendance = await db.Attendance.FindAsync(id);
            db.Attendance.Remove(attendance);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            { 
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
