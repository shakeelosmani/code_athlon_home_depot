/*
 * JS for PRO_Notifications generated by Appery.io
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

function PRO_Notifications_js() {

    /* Object & array with components "name-to-id" mapping */
    var n2id_buf = {
        'mobilecollapsibleset_27': 'PRO_Notifications_mobilecollapsibleset_27',
        'mobilecollapsblock_28': 'PRO_Notifications_mobilecollapsblock_28',
        'mobilecollapsblockheader_29': 'PRO_Notifications_mobilecollapsblockheader_29',
        'mobilecollapsblockcontent_30': 'PRO_Notifications_mobilecollapsblockcontent_30',
        'CustomComponent1_9': 'PRO_Notifications_CustomComponent1_9',
        'CustomComponent1_9_mobilenavbar_36': 'PRO_Notifications_CustomComponent1_9_mobilenavbar_36',
        'CustomComponent1_9_mobilenavbaritem_37': 'PRO_Notifications_CustomComponent1_9_mobilenavbaritem_37',
        'CustomComponent1_9_mobilenavbaritem_38': 'PRO_Notifications_CustomComponent1_9_mobilenavbaritem_38'
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

    Apperyio.mappings["PRO_Notifications_store_message_db_onbeforesend_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": [

        {
            "from_name": "notificationData",
            "from_type": "LOCAL_STORAGE",

            "to_name": "store_message_db",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "headers": {
                    "X-Appery-Database-Id": "{database_id}",
                    "Content-Type": "application/json"
                },
                "parameters": {},
                "body": {
                    "acl": {
                        "*": {
                            "write": true,
                            "read": true
                        }
                    }
                }
            },

            "mappings": [

            {

                "source": "$",
                "target": "$['body']['message']"

            }

            ]
        }

        ]
    };

    Apperyio.mappings["PRO_Notifications_store_message_db_onsuccess_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": []
    };

    Apperyio.mappings["PRO_Notifications_get_gps_data1_onbeforesend_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": [

        {

            "to_name": "get_gps_data1",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "data": {
                    "options": {
                        "maximumAge": 3000,
                        "timeout": 5000,
                        "enableHighAccuracy": true,
                        "watchPosition": false
                    }
                }
            },

            "mappings": []
        }

        ]
    };

    Apperyio.mappings["PRO_Notifications_get_gps_data1_onsuccess_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": [

        {
            "from_name": "get_gps_data1",
            "from_type": "SERVICE_RESPONSE",

            "to_name": "lat",
            "to_type": "LOCAL_STORAGE",

            "mappings": [

            {

                "source": "$['data']['coords']['latitude']",
                "target": "$"

            }

            ]
        },

        {
            "from_name": "get_gps_data1",
            "from_type": "SERVICE_RESPONSE",

            "to_name": "lon",
            "to_type": "LOCAL_STORAGE",

            "mappings": [

            {

                "source": "$['data']['coords']['longitude']",
                "target": "$"

            }

            ]
        }

        ]
    };

    Apperyio.mappings["PRO_Notifications_save_gps_data1_onsuccess_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": []
    };

    Apperyio.mappings["PRO_Notifications_save_gps_data1_onbeforesend_mapping_0"] = {
        "homeScreen": "PRO_Notifications",
        "directions": [

        {
            "from_name": "lon",
            "from_type": "LOCAL_STORAGE",

            "to_name": "save_gps_data1",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "headers": {
                    "X-Appery-Database-Id": "{database_id}",
                    "Content-Type": "application/json"
                },
                "parameters": {},
                "body": {
                    "acl": {
                        "*": {
                            "write": true,
                            "read": true
                        }
                    }
                }
            },

            "mappings": [

            {

                "source": "$",
                "target": "$['body']['location'][0]"

            }

            ]
        },

        {
            "from_name": "lat",
            "from_type": "LOCAL_STORAGE",

            "to_name": "save_gps_data1",
            "to_type": "SERVICE_REQUEST",

            "to_default": {
                "headers": {
                    "X-Appery-Database-Id": "{database_id}",
                    "Content-Type": "application/json"
                },
                "parameters": {},
                "body": {
                    "acl": {
                        "*": {
                            "write": true,
                            "read": true
                        }
                    }
                }
            },

            "mappings": [

            {

                "source": "$",
                "target": "$['body']['location'][1]"

            }

            ]
        }

        ]
    };

    Apperyio.datasources = Apperyio.datasources || {};

    window.store_message_db = Apperyio.datasources.store_message_db = new Apperyio.DataSource(HomeDepot_messages_create_service, {
        "onBeforeSend": function(jqXHR) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_store_message_db_onbeforesend_mapping_0"]);
        },
        "onComplete": function(jqXHR, textStatus) {

        },
        "onSuccess": function(data) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_store_message_db_onsuccess_mapping_0"]);
        },
        "onError": function(jqXHR, textStatus, errorThrown) {}
    });

    window.get_gps_data1 = Apperyio.datasources.get_gps_data1 = new Apperyio.DataSource(GeolocationService, {
        "onBeforeSend": function(jqXHR) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_get_gps_data1_onbeforesend_mapping_0"]);
        },
        "onComplete": function(jqXHR, textStatus) {

        },
        "onSuccess": function(data) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_get_gps_data1_onsuccess_mapping_0"]);
            Apperyio("gps_data").val(localStorage.getItem("lat") + "," + localStorage.getItem("lon"));
            Apperyio("DeviceID").value(localStorage.getItem('pushNotificationDeviceID'));
            try {
                get_gps_data1.execute({});
            } catch (e) {
                console.error(e);
                hideSpinner();
            };
        },
        "onError": function(jqXHR, textStatus, errorThrown) {}
    });

    window.save_gps_data1 = Apperyio.datasources.save_gps_data1 = new Apperyio.DataSource(Topics_Locations_update_service, {
        "onBeforeSend": function(jqXHR) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_save_gps_data1_onbeforesend_mapping_0"]);
        },
        "onComplete": function(jqXHR, textStatus) {

        },
        "onSuccess": function(data) {
            Apperyio.processMappingAction(Apperyio.mappings["PRO_Notifications_save_gps_data1_onsuccess_mapping_0"]);
        },
        "onError": function(jqXHR, textStatus, errorThrown) {}
    });

    Apperyio.CurrentScreen = 'PRO_Notifications';
    _.chain(Apperyio.mappings).filter(function(m) {
        return m.homeScreen === Apperyio.CurrentScreen;
    }).each(Apperyio.UIHandler.hideTemplateComponents);

    /*
     * Events and handlers
     */

    // On Load
    var PRO_Notifications_onLoad = function() {
            PRO_Notifications_elementsExtraJS();

            PRO_Notifications_deviceEvents();
            PRO_Notifications_windowEvents();
            PRO_Notifications_elementsEvents();
        };

    // screen window events


    function PRO_Notifications_windowEvents() {

        $('#PRO_Notifications').bind('pageshow orientationchange', function() {
            var _page = this;
            adjustContentHeightWithPadding(_page);
        });

    };

    // device events


    function PRO_Notifications_deviceEvents() {
        document.addEventListener("deviceready", function() {
            get_gps_data.execute({});

            save_gps_data.execute({});

            GPSInterval = setInterval(function() {
                get_gps_data.execute({});
            }, GPSInterval * 1000);
            $(document).off('push-notification ').on({
                "push-notification": function(event) {
                    try {
                        $a.storage["notificationData"].update("$", "data.message")
                    } catch (e) {
                        console.error(e)
                    };
                    try {
                        store_message_db.execute({});
                    } catch (e) {
                        console.error(e);
                        hideSpinner();
                    };
                },
            });

        });
    };

    // screen elements extra js


    function PRO_Notifications_elementsExtraJS() {
        // screen (PRO_Notifications) extra code

        /* mobilecollapsblock_28 */

        $("#PRO_Notifications_mobilecollapsblock_28 .ui-collapsible-heading-toggle").attr("tabindex", "9");

    };

    // screen elements handler


    function PRO_Notifications_elementsEvents() {
        $(document).on("click", "a :input,a a,a fieldset label", function(event) {
            event.stopPropagation();
        });

        $(document).off("click", '#PRO_Notifications_mobilefooter [name="CustomComponent1_9_mobilenavbaritem_37"]').on({
            click: function(event) {
                if (!$(this).attr('disabled')) {
                    Apperyio.navigateTo('PRO_Notifications', {
                        transition: 'flip',
                        reverse: false
                    });

                }
            },
        }, '#PRO_Notifications_mobilefooter [name="CustomComponent1_9_mobilenavbaritem_37"]');
        $(document).off("click", '#PRO_Notifications_mobilefooter [name="CustomComponent1_9_mobilenavbaritem_38"]').on({
            click: function(event) {
                if (!$(this).attr('disabled')) {
                    Apperyio.navigateTo('Leaderboard_screen', {
                        transition: 'flip',
                        reverse: false
                    });

                }
            },
        }, '#PRO_Notifications_mobilefooter [name="CustomComponent1_9_mobilenavbaritem_38"]');

    };

    $(document).off("pagebeforeshow", "#PRO_Notifications").on("pagebeforeshow", "#PRO_Notifications", function(event, ui) {
        Apperyio.CurrentScreen = "PRO_Notifications";
        _.chain(Apperyio.mappings).filter(function(m) {
            return m.homeScreen === Apperyio.CurrentScreen;
        }).each(Apperyio.UIHandler.hideTemplateComponents);
    });

    PRO_Notifications_onLoad();
};

$(document).off("pagecreate", "#PRO_Notifications").on("pagecreate", "#PRO_Notifications", function(event, ui) {
    Apperyio.processSelectMenu($(this));
    PRO_Notifications_js();
});