(function () {
    var chat = $.connection.chat;

    $.connection.hub.start()
        .done(function () {
            $.connection.hub.logging = true;
            writeToPage("It worked!");
            $.connection.hub.log("Connected");
            //console.log($.connection.myHub)
            chat.server.announceToEveryBody("Connected!");
        })
        .fail(function () {
            writeToPage("Error connecting to SignalR...");
        });

    chat.client.announce = function (message) {
        writeToPage(message);
    };

    var writeToPage = function (message) {
        $("#welcome-messages").append(message + "<br />");
    };

    $("#click-me").on("click", function () {
        chat.server.getServerDateTime()
            .done(function (data) {
                writeToPage(data)
            })
            .fail(function (e) {
                writeToPage(e)
            })
    })
})()