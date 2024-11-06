document.addEventListener('DOMContentLoaded', function() {
    const themeToggle = document.getElementById('theme-toggle');
    themeToggle.addEventListener('click', function() {
        document.body.classList.toggle('dark-theme');
        document.querySelectorAll('header, section, footer').forEach(element => {
            element.classList.toggle('dark-theme');
        });
    });

    const skills = document.querySelectorAll('.skills-list li');
    skills.forEach(skill => {
        skill.addEventListener('click', function() {
            alert(`Ви натиснули на навичку: ${this.textContent}`);
        });
    });
});
