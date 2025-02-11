// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const toolLinks = document.querySelectorAll('.tool-link');

    toolLinks.forEach(link => {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            const toolItem = this.closest('.tool-item');
            const stickyNote = toolItem.querySelector('.sticky-note');

            // 关闭其他打开的便利贴
            document.querySelectorAll('.sticky-note').forEach(note => {
                if (note !== stickyNote) {
                    note.style.display = 'none';
                }
            });

            // 显示当前便利贴
            stickyNote.style.display = 'block';
            document.body.classList.add('modal-open');

            // 关闭按钮事件
            const closeBtn = stickyNote.querySelector('.close-btn');
            closeBtn.onclick = function (e) {
                e.stopPropagation(); // 阻止事件冒泡
                stickyNote.style.display = 'none';
                document.body.classList.remove('modal-open');
            };
        });
    });

    // 点击便利贴外部区域关闭
    document.addEventListener('click', function (e) {
        if (!e.target.closest('.sticky-note') && !e.target.closest('.tool-link')) {
            document.querySelectorAll('.sticky-note').forEach(note => {
                note.style.display = 'none';
            });
            document.body.classList.remove('modal-open');
        }
    });
});