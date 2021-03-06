/*
 * JS for PhantomLandingPage generated by Appery.io
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

function PhantomLandingPage_js() {

    /* Object & array with components "name-to-id" mapping */
    var n2id_buf = {
        'imageregister': 'PhantomLandingPage_imageregister'
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

    Apperyio.mappings["PhantomLandingPage_restservice4_onsuccess_mapping_0"] = {
        "homeScreen": "PhantomLandingPage",
        "directions": [

        {
            "from_name": "restservice4",
            "from_type": "SERVICE_RESPONSE",

            "to_name": "Registered",
            "to_type": "LOCAL_STORAGE",

            "mappings": [

            {

                "source": "$['body']['DeviceID']",
                "target": "$"

            }

            ]
        },

        {
            "from_name": "restservice4",
            "from_type": "SERVICE_RESPONSE",

            "to_name": "isPro",
            "to_type": "LOCAL_STORAGE",

            "mappings": [

            {

                "source": "$['body']['Pro']",
                "target": "$"

            }

            ]
        }

        ]
    };

    Apperyio.mappings["PhantomLandingPage_restservice4_onbeforesend_mapping_0"] = {
        "homeScreen": "PhantomLandingPage",
        "directions": [

        {
            "from_name": "DeviceID",
            "from_type": "LOCAL_STORAGE",

            "to_name": "restservice4",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "headers": {
                    "X-Appery-Database-Id": "{database_id}"
                },
                "parameters": {},
                "body": null
            },

            "mappings": [

            {

                "source": "$",
                "target": "$['parameters']['DeviceID']"

            }

            ]
        }

        ]
    };

    Apperyio.datasources = Apperyio.datasources || {};

    window.restservice4 = Apperyio.datasources.restservice4 = new Apperyio.DataSource(Topics_UserReg_read_service, {
        "onBeforeSend": function(jqXHR) {
            Apperyio.processMappingAction(Apperyio.mappings["PhantomLandingPage_restservice4_onbeforesend_mapping_0"]);
        },
        "onComplete": function(jqXHR, textStatus) {

        },
        "onSuccess": function(data) {
            Apperyio.processMappingAction(Apperyio.mappings["PhantomLandingPage_restservice4_onsuccess_mapping_0"]);
        },
        "onError": function(jqXHR, textStatus, errorThrown) {}
    });

    Apperyio.CurrentScreen = 'PhantomLandingPage';
    _.chain(Apperyio.mappings).filter(function(m) {
        return m.homeScreen === Apperyio.CurrentScreen;
    }).each(Apperyio.UIHandler.hideTemplateComponents);

    /*
     * Events and handlers
     */

    // On Load
    var PhantomLandingPage_onLoad = function() {
            PhantomLandingPage_elementsExtraJS();

            PhantomLandingPage_deviceEvents();
            PhantomLandingPage_windowEvents();
            PhantomLandingPage_elementsEvents();
        };

    // screen window events


    function PhantomLandingPage_windowEvents() {

        $('#PhantomLandingPage').bind('pageshow orientationchange', function() {
            var _page = this;
            adjustContentHeightWithPadding(_page);
        });

    };

    // device events


    function PhantomLandingPage_deviceEvents() {
        document.addEventListener("deviceready", function() {
            var deviceID = localStorage.getItem('pushNotificationDeviceID');
            Apperyio('DeviceID').val(deviceID);
            try {
                restservice4.execute({});
            } catch (e) {
                console.error(e);
                hideSpinner();
            };
            setTimeout(function() {
                alert(localStorage.getItem('Registered'));
            }, 1);

            if (localStorage.getItem('Registered') !== "" && localStorage.getItem('isPro')) {
                Apperyio.navigateTo("PRO_Notifications");
            } else if (localStorage.getItem('Registered') !== "" && !(localStorage.getItem('isPro'))) {
                Apperyio.navigateTo("Customer_Screen1");
            } else {
                Apperyio.navigateTo("Register");
            }

            ;

        });
    };

    // screen elements extra js


    function PhantomLandingPage_elementsExtraJS() {
        // screen (PhantomLandingPage) extra code

    };

    // screen elements handler


    function PhantomLandingPage_elementsEvents() {
        $(document).on("click", "a :input,a a,a fieldset label", function(event) {
            event.stopPropagation();
        });

    };

    $(document).off("pagebeforeshow", "#PhantomLandingPage").on("pagebeforeshow", "#PhantomLandingPage", function(event, ui) {
        Apperyio.CurrentScreen = "PhantomLandingPage";
        _.chain(Apperyio.mappings).filter(function(m) {
            return m.homeScreen === Apperyio.CurrentScreen;
        }).each(Apperyio.UIHandler.hideTemplateComponents);
    });

    PhantomLandingPage_onLoad();
};

$(document).off("pagecreate", "#PhantomLandingPage").on("pagecreate", "#PhantomLandingPage", function(event, ui) {
    Apperyio.processSelectMenu($(this));
    PhantomLandingPage_js();
});