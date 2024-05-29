let categoryArchiveBtns = document.querySelectorAll(".add-archive");
let categoryRestoreBtns = document.querySelectorAll(".add-restore");

console.log(categoryRestoreBtns)



categoryArchiveBtns.forEach(item =>
    item.addEventListener("click", function () {
        let id = parseInt(this.getAttribute("data-id"));
        console.log(id);

        fetch(`category/settoarchive?id=${id}`, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                console.log(response)

                if (response.ok) {
                    this.closest(".category-data").remove();
                } else {
                    console.error('Failed to archive category');
                }
            })
            .catch(error => console.error('Error:', error));
    })
);



categoryRestoreBtns.forEach(item =>
    item.addEventListener("click", function () {
        let id = parseInt(this.getAttribute("data-id"));
        console.log(id);

        fetch(`archive/settorestore?id=${id}`, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                console.log(response)
                if (response.ok) {
                    this.closest(".category-data").remove();
                } else {
                    console.error('Failed to restore category');
                }
            })
            .catch(error => console.error('Error:', error));
    })
);
