/*
 * Service settings
 */
var Topics_settings = {
    "database_url": "https://api.appery.io/rest/1/db",
    "database_id": "56c6cda0e4b07f15da1aab51"
}
var HomeDepot_settings = {
    "database_url": "https://api.appery.io/rest/1/db",
    "database_id": "56c7777ce4b03ef3938ced21"
}
var GPSLocationTracking_settings = {
    "database_url": "https://api.appery.io/rest/1/db",
    "database_id": "56c6cda0e4b07f15da1aab51"
}
var Database_settings_Barcode_Scanner_with_Database_Example = {
    "database_url": "https://api.appery.io/rest/1/db",
    "database_id": ""
}
var Database_settings = {
    "database_url": "https://api.appery.io/rest/1/db",
    "database_id": ""
}

/*
 * Services
 */

var Topics_GeoFences_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/GeoFences',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var Topics_User_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/User',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': Topics_settings
});

var Topics_UserReg_read_service = new Apperyio.RestService({
    'url': '{database_url}/collections/UserReg/{_id}',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var SendPushService = new Apperyio.RestService({
    'url': 'https://api.appery.io/rest/push/msg',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',
});

var ReceivePushService = new Apperyio.RestService({
    'url': '',
    'dataType': 'json',
    'type': 'get',
});

var Topics_User_read_service = new Apperyio.RestService({
    'url': '{database_url}/collections/User/{_id}',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var Topics_Locations_update_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Locations/{_id}',
    'dataType': 'json',
    'type': 'put',
    'contentType': 'application/json',

    'serviceSettings': Topics_settings
});
var CameraService_ServicePattern_Mobile_API = new Apperyio.CameraService({});

var GetCategoryName = new Apperyio.RestService({
    'url': '',
    'dataType': 'json',
    'type': 'get',
});

var TwilioRESTService = new Apperyio.RestService({
    'url': 'https://api.appery.io/rest/1/proxy/tunnel',
    'proxyHeaders': {
        'appery-proxy-url': 'https://AC973a4ea58f9173a0bba07da2454ffa25:02b040850bcf984b7c073507093d4580@api.twilio.com/2010-04-01/Accounts/AC973a4ea58f9173a0bba07da2454ffa25/Messages.json',
        'appery-transformation': 'checkTunnel',
        'appery-key': '1456006037452',
        'appery-rest': '4f4c453a-d8b7-46bd-a611-edb34a85f960'
    },
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/x-www-form-urlencoded',
});

var Topics_Categories_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var Topics_Categories_query_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var PushReg = new Apperyio.RestService({
    'url': 'https://api.appery.io/rest/push/reg/',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',
});

var Topics_Locations_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Locations',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': GPSLocationTracking_settings
});

var Topics_Locations_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Locations',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});

var Topics_Locations_delete_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Locations/{_id}',
    'dataType': 'json',
    'type': 'delete',

    'serviceSettings': Topics_settings
});

var ConditionsService = new Apperyio.RestService({
    'url': 'https://api.appery.io/rest/1/proxy/tunnel',
    'proxyHeaders': {
        'appery-proxy-url': 'http://api.wunderground.com/api/{api_key}/conditions/q/{airport_or_geo}.json',
        'appery-transformation': 'checkTunnel',
        'appery-key': '1456006037452',
        'appery-rest': 'abbcbf86-3ce2-434c-9c5c-555a8e31bce0'
    },
    'dataType': 'json',
    'type': 'get',
});

var Topics_Categories_update_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories/{_id}',
    'dataType': 'json',
    'type': 'put',
    'contentType': 'application/json',

    'serviceSettings': Topics_settings
});

var Topics_Categories_delete_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories/{_id}',
    'dataType': 'json',
    'type': 'delete',

    'serviceSettings': Topics_settings
});

var Topics_Categories_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': Topics_settings
});

var Topics_Categories_read_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Categories/{_id}',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Topics_settings
});
var BarcodeService = new Apperyio.BarCodeService({});

var Database_Products_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Products',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Database_settings_Barcode_Scanner_with_Database_Example
});

var HomeDepot_messages_read_service = new Apperyio.RestService({
    'url': '{database_url}/collections/messages/{_id}',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': HomeDepot_settings
});

var Database_Products_query_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Products',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Database_settings_Barcode_Scanner_with_Database_Example
});
var GeolocationService = new Apperyio.GeolocationService({});

var HomeDepot_messages_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/messages',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': HomeDepot_settings
});

var Topics_UserReg_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/UserReg',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': Topics_settings
});

var Database_Products_update_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Products/{_id}',
    'dataType': 'json',
    'type': 'put',
    'contentType': 'application/json',

    'serviceSettings': Database_settings_Barcode_Scanner_with_Database_Example
});

var HomeDepot_messages_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/messages',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': HomeDepot_settings
});

var Database_Products_create_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Products',
    'dataType': 'json',
    'type': 'post',
    'contentType': 'application/json',

    'serviceSettings': Database_settings_Barcode_Scanner_with_Database_Example
});
var CameraService = new Apperyio.CameraService({});

var Database_list_service = new Apperyio.RestService({
    'url': '{database_url}/collections/Products',
    'dataType': 'json',
    'type': 'get',

    'serviceSettings': Database_settings
});