var fnObj = fnObj || {};
fnObj.ajax = {
    history: {
        init: function() {
            var a = $('#ajaxContents').find(".boardView").length ? "view" : "list";

            fnObj.ajax.history.replace({
                type: a
                , url: document.URL
            })
            , window.onpopstate = function (e) {
                e.state && (fnObj.ajax.load({
                    type: e.state.type,
                    url: e.state.url,
                    popstate: !0
                }))
            }
        }
        , push: function (obj) {
            history.pushState({
                type: obj.type
                , url: obj.url                
            }, "", obj.url)
        }
        , replace: function (obj) {
            history.replaceState({
                type: obj.type
                , url: obj.url
            }, "", obj.url)
        }
    }
    , load: function (obj) {
        $.ajax({
            type: "POST"
            , url: obj.url
            , success: function (data) {
                var tmp = $("<html />").html(data);
                
                // history
                !obj.popstate && fnObj.ajax.history.push({                    
                    type: obj.type,
                    url: obj.url,                    
                });

                var contents = tmp.find('#contents');

                $('#contents').hide();
                $('#ajaxContents').html(contents);
            }
        });
    }
}

$(document).ready(function () {
    // historyInit
    fnObj.ajax.history.init();

    $(document).on('click', 'a[data-ajax-board]', function (e) {
        fnObj.ajax.load({
            type: $(this).attr("data-ajax-board")
            , url: $(this).attr("href")
        }), e.preventDefault()
    });
});