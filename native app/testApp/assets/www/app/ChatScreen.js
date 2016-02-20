/*
 * JS for ChatScreen generated by Appery.io
 */

Apperyio.getProjectGUID = function() {
    return 'acbd3c08-ccac-48b5-bd59-d5a5b5e6c12f';
};

function navigateTo(outcome, useAjax) {
    Apperyio.navigateTo(outcome, useAjax);
}

function adjustContentHeight() {
    Apperyio.adjustContentHeightWithPadding();
}

function adjustContentHeightWithPadding(_page) {
    Apperyio.adjustContentHeightWithPadding(_page);
}

function setDetailContent(pageUrl) {
    Apperyio.setDetailContent(pageUrl);
}

Apperyio.AppPages = [{
    "name": "maps",
    "location": "maps.html"
}, {
    "name": "PhantomLandingPage",
    "location": "PhantomLandingPage.html"
}, {
    "name": "PRO_Connect",
    "location": "PRO_Connect.html"
}, {
    "name": "DescriptionPage",
    "location": "DescriptionPage.html"
}, {
    "name": "Customer_Screen_1",
    "location": "Customer_Screen_1.html"
}, {
    "name": "Register",
    "location": "Register.html"
}, {
    "name": "Leaderboard_screen",
    "location": "Leaderboard_screen.html"
}, {
    "name": "ChatScreen",
    "location": "ChatScreen.html"
}, {
    "name": "Products",
    "location": "Products.html"
}, {
    "name": "PRO_Notifications",
    "location": "PRO_Notifications.html"
}, {
    "name": "WaitPage",
    "location": "WaitPage.html"
}, {
    "name": "HomeScreen",
    "location": "HomeScreen.html"
}];

function ChatScreen_js() {

    /* Object & array with components "name-to-id" mapping */
    var n2id_buf = {
        'mobiletextinput_2': 'ChatScreen_mobiletextinput_2',
        'mobiletextarea_3': 'ChatScreen_mobiletextarea_3',
        'mobilebutton_4': 'ChatScreen_mobilebutton_4'
    };

    if ("n2id" in window && window.n2id !== undefined) {
        $.extend(n2id, n2id_buf);
    } else {
        window.n2id = n2id_buf;
    }

    /*
     * Nonvisual components
     */

    Apperyio.mappings = Apperyio.mappings || {};

    Apperyio.mappings["ChatScreen_restservice3_onsuccess_mapping_0"] = {
        "homeScreen": "ChatScreen",
        "directions": []
    };

    Apperyio.mappings["ChatScreen_restservice3_onbeforesend_mapping_0"] = {
        "homeScreen": "ChatScreen",
        "directions": [

        {
            "from_name": "ChatScreen",
            "from_type": "UI",

            "to_name": "restservice3",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "headers": {
                    "Content-Type": "application/x-www-form-urlencoded"
                },
                "parameters": {},
                "body": {
                    "From": "+16782519020"
                }
            },

            "mappings": [

            {

                "source": "$['mobiletextinput_2:text']",
                "target": "$['body']['To']"

            },

            {

                "source": "$['mobiletextarea_3:text']",
                "target": "$['body']['Body']"

            }

            ]
        }

        ]
    };

    Apperyio.datasources = Apperyio.datasources || {};

    window.restservice3 = Apperyio.datasources.restservice3 = new Apperyio.DataSource(TwilioRESTService, {
        "onBeforeSend": function(jqXHR) {
            Apperyio.processMappingAction(Apperyio.mappings["ChatScreen_restservice3_onbeforesend_mapping_0"]);
        },
        "onComplete": function(jqXHR, textStatus) {

        },
        "onSuccess": function(data) {
            Apperyio.processMappingAction(Apperyio.mappings["ChatScreen_restservice3_onsuccess_mapping_0"]);
        },
        "onError": function(jqXHR, textStatus, errorThrown) {}
    });

    Apperyio.CurrentScreen = 'ChatScreen';
    _.chain(Apperyio.mappings).filter(function(m) {
        return m.homeScreen === Apperyio.CurrentScreen;
    }).each(Apperyio.UIHandler.hideTemplateComponents);

    /*
     * Events and handlers
     */

    // On Load
    var ChatScreen_onLoad = function() {
            ChatScreen_elementsExtraJS();

            ChatScreen_deviceEvents();
            ChatScreen_windowEvents();
            ChatScreen_elementsEvents();
        };

    // screen window events


    function ChatScreen_windowEvents() {

        $('#ChatScreen').bind('pageshow orientationchange', function() {
            var _page = this;
            adjustContentHeightWithPadding(_page);
        });

    };

    // device events


    function ChatScreen_deviceEvents() {
        document.addEventListener("deviceready", function() {

        });
    };

    // screen elements extra js


    function ChatScreen_elementsExtraJS() {
        // screen (ChatScreen) extra code

    };

    // screen elements handler


    function ChatScreen_elementsEvents() {
        $(document).on("click", "a :input,a a,a fieldset label", function(event) {
            event.stopPropagation();
        });

        $(document).off("click", '#ChatScreen_mobilecontainer [name="mobilebutton_4"]').on({
            click: function(event) {
                if (!$(this).attr('disabled')) {
                    try {
                        restservice3.execute({});
                    } catch (e) {
                        console.error(e);
                        hideSpinner();
                    };

                }
            },
        }, '#ChatScreen_mobilecontainer [name="mobilebutton_4"]');

    };

    $(document).off("pagebeforeshow", "#ChatScreen").on("pagebeforeshow", "#ChatScreen", function(event, ui) {
        Apperyio.CurrentScreen = "ChatScreen";
        _.chain(Apperyio.mappings).filter(function(m) {
            return m.homeScreen === Apperyio.CurrentScreen;
        }).each(Apperyio.UIHandler.hideTemplateComponents);
    });

    ChatScreen_onLoad();
};

$(document).off("pagecreate", "#ChatScreen").on("pagecreate", "#ChatScreen", function(event, ui) {
    Apperyio.processSelectMenu($(this));
    ChatScreen_js();
});