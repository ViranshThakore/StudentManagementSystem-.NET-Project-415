using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;
using StudentManagementSystem.Data;
namespace StudentManagementSystem.Controllers;


public class StudentsController : Controller
{
    private readonly AppDbContext _db;
    public StudentsController(AppDbContext db) => _db = db;

    public async Task<IActionResult> Index(string search)
    {
        var query = _db.Students.AsQueryable();
        if (!string.IsNullOrWhiteSpace(search))
            query = query.Where(s => s.FirstName.Contains(search) || s.LastName.Contains(search) || s.RollNo.Contains(search));
        var students = await query.OrderByDescending(s => s.CreatedAt).ToListAsync();
        return View(students);
    }

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Student student)
    {
        if (!ModelState.IsValid) return View(student);
        _db.Add(student);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var student = await _db.Students.FindAsync(id);
        if (student == null) return NotFound();
        return View(student);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Student student)
    {
        if (id != student.Id) return BadRequest();
        if (!ModelState.IsValid) return View(student);
        _db.Update(student);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var student = await _db.Students.FindAsync(id);
        if (student == null) return NotFound();
        return View(student);
    }

    [HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var student = await _db.Students.FindAsync(id);
    if (student == null)
    {
        return NotFound();
    }

    _db.Students.Remove(student);
    await _db.SaveChangesAsync();
    return RedirectToAction(nameof(Index));
}


    public async Task<IActionResult> Details(int id)
{
    var student = await _db.Students.FirstOrDefaultAsync(s => s.Id == id);
    if (student == null)
        return NotFound();

    return View(student);
}

}
