(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("it worked!");
            console.log($.connection.myHub)
            $.connection.myHub.server.announce("connected");
        })
        .fail(function () { alert("error"); });

    $.connection.myHub.client.announce = function (message) {
        $("#welcome-messages").append(message);
    };
})()