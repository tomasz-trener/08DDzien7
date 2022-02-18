


$(document).ready(function () {



    $("#dvLupka").click(function () {

        $("table").hide();
        $("#dvLadowanie").show();

        /* $("#spWynik").html("ala ma kota");*/

        var filtr = $("#txtFiltr").val();


        $.ajax({
            method: "POST",
            url: "DefaultServer.aspx",
            data: { filtr: filtr }
        })
            .done(function (msg) {
                // debugger

                // msg to są zawodnicy sformatowani do formatu JSON i teraz
                // musimy sparsować JSONA (czyli przekonwertować do tablicy obiektu ale tym  raz w javascipt )
                var zawodnicy = JSON.parse(msg);
                var napis = "";
                for (var i = 0; i < zawodnicy.length; i++) {
                    napis += "<tr>" +
                        "<td>" + zawodnicy[i].ImieNazwisko + "</td>" +
                        "<td>" + zawodnicy[i].Kraj + "</td>" +
                        "<td>" + zawodnicy[i].Wzrost + "</td>" +
                        "<td>" + zawodnicy[i].Waga + "</td>" +
                        "<td>" + new Date(parseInt(zawodnicy[i].DataUrodzenia.substring(6))).toLocaleDateString("pl-pl") + "</td>" + "</tr>";
                }

                $("table tbody").html(napis)

                $("table").show();
                $("#dvLadowanie").hide();
            });

    });


});
