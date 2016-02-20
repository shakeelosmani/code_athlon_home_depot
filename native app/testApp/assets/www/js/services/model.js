/**
 * Data models
 */
Apperyio.Entity = new Apperyio.EntityFactory({
    "Number": {
        "type": "number"
    },
    "Boolean": {
        "type": "boolean"
    },
    "GeoFence": {
        "type": "object",
        "properties": {
            "LeftBottom": {
                "type": "object",
                "properties": {
                    "lat": {
                        "type": "number"
                    },
                    "lon": {
                        "type": "number"
                    }
                }
            },
            "RightTop": {
                "type": "object",
                "properties": {
                    "lat": {
                        "type": "number"
                    },
                    "lon": {
                        "type": "number"
                    }
                }
            }
        }
    },
    "ProductList": {
        "type": "array",
        "items": {
            "type": "string"
        }
    },
    "String": {
        "type": "string"
    }
});
Apperyio.getModel = Apperyio.Entity.get.bind(Apperyio.Entity);

/**
 * Data storage
 */
Apperyio.storage = {

    "lon": new $a.LocalStorage("lon", "Number"),

    "lat": new $a.LocalStorage("lat", "Number"),

    "gps_data": new $a.LocalStorage("gps_data", "String"),

    "DeviceID": new $a.LocalStorage("DeviceID", "String"),

    "notificationData": new $a.LocalStorage("notificationData", "String"),

    "ProToggle": new $a.LocalStorage("ProToggle", "Boolean"),

    "FName": new $a.LocalStorage("FName", "String"),

    "LName": new $a.LocalStorage("LName", "String"),

    "Email": new $a.LocalStorage("Email", "String"),

    "CategoryList": new $a.LocalStorage("CategoryList", "ProductList"),

    "Registered": new $a.LocalStorage("Registered", "String"),

    "isPro": new $a.LocalStorage("isPro", "Boolean"),

    "Geofence": new $a.LocalStorage("Geofence", "GeoFence"),

    "GeofenceName": new $a.LocalStorage("GeofenceName", "String")
};

/**
 * Push Notification specific data storage
 */
Apperyio.storage.pushNotificationToken = new $a.LocalStorage("pushNotificationToken", "String");
Apperyio.storage.pushNotificationDeviceID = new $a.LocalStorage("pushNotificationDeviceID", "String");
Apperyio.storage.deviceTimeZone = new $a.LocalStorage("deviceTimeZone", "String");