document.addEventListener('DOMContentLoaded', function () {
    const pageSize = 20;
    const rows = document.querySelectorAll('tbody tr');
    const numPages = Math.ceil(rows.length / pageSize);

    function displayPage(page) {
        const startIndex = (page - 1) * pageSize;
        const endIndex = startIndex + pageSize;
        rows.forEach((row, index) => {
            row.style.display = index >= startIndex && index < endIndex ? '' : 'none';
        });
    }

    function createPaginationLinks() {
        const pagination = document.getElementById('pagination');
        pagination.innerHTML = '';

        for (let i = 1; i <= numPages; i++) {
            const li = document.createElement('li');
            li.classList.add('page-item'); // Adicionando a classe 'page-item' ao elemento <li>

            const link = document.createElement('a');
            link.href = '#';
            link.textContent = i;
            link.classList.add('page-link'); // Adicionando a classe 'page-link' ao elemento <a>
            link.onclick = function () {
                displayPage(i);
            };

            li.appendChild(link);
            pagination.appendChild(li);
        }
    }

    createPaginationLinks();
    displayPage(1);
});