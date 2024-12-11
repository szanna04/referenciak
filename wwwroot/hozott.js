document.getElementById("ujfilm").addEventListener("click", () => {
    var bookData = {

        "title": document.getElementById("cim").value,
        "releaseYear": document.getElementById("ev").value,
        "genre": document.getElementById("mufaj").value,
        "isAvailable": document.getElementById("elerheto").Checked == "Ok"
    }

    fetch("api/film", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(bookData)
    })
        .then(v => {
            if (v.ok) {
                alert("siker")
            }
            else { alert("hiba") }
        })
});


document.getElementById("megjelenitogomb").addEventListener("click", () => { //gomb megnyomásával jelenik meg
    fetch("api/film").then(v => v.json()).then(o => {     //fontos a zárójel a jsonnél

        let tbody = document.getElementById("tb_filmek");
        tbody.innerHTML = ""; //üresre állítom
        console.log(o);

        var tábla = document.getElementById("tb_filmek");
        for (var i = 0; i < o.length; i++) {

            var sor = document.createElement("tr");
            sor.innerHTML = `
                                                <td>${o[i].filmId}</td>
                                                <td>${o[i].title}</td>
                                                <td>${o[i].releaseYear}</td>
                                                <td>${o[i].genre}</td>
                                                <td>${o[i].isAvailable}</td>
                                                `;
            tábla.appendChild(sor);
        }
    })
});

