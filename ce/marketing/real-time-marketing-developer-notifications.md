---
title: "Receiving notifications and creating interactions (Dynamics 365 Marketing) | Microsoft Docs"
description: "Developer: learn how to receive notifications from real-time marketing in Dynamics 365 Marketing."
ms.date: 03/21/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Receiving notifications and creating interactions

Notifications received from Dynamics 365 Marketing have an additional payload containing links and a **trackingId** for interaction event creation.

> [!IMPORTANT]
> To track links that recipients open in notifications, you must collect customer tracking consent. Dynamics 365 Marketing has no way to collect this consent for you.
>
> If you have not collected tracking consent, you must use the **originalLink** URL field described in the code snippet below. If you have acquired consent, you can use the **link** field value, which will be trackable.
>
> *PushLinkClicked* will be automatically generated. The URL is a redirect link which will create the interaction if the link from the **link** field is used.

## Receive notifications in iOS

Sample code snippet to parse the incoming notifications in iOS:

```
- (void)application:(UIApplication *)application didReceiveRemoteNotification:(NSDictionary *)userInfo fetchCompletionHandler:(void (^)(UIBackgroundFetchResult))completionHandler
{

// Print full message
    NSString *urlString = [[userInfo valueForKey:@"data"] valueForKey:@"link"];
    NSString *originalUrlString = [[userInfo valueForKey:@"data"] valueForKey:@"originalLink"];
    NSString *trackingIdString = [[userInfo valueForKey:@"data"] valueForKey:@"trackingId"];
    
    if(![urlString isEqual:[NSNull null]])
    {
        if([urlString length] != 0)
        {
            [self createInteraction:[NSNumber numberWithInt:0] stringTracking:trackingIdString];
            
            NSURL *url = [NSURL URLWithString:urlString];
            if ([[[UIDevice currentDevice] systemVersion] floatValue] >= 10) {
                
// iOS 10 and above
                [[UIApplication sharedApplication] openURL:url options:[NSDictionary dictionary] completionHandler:nil];
            }
            else
            {
                [[UIApplication sharedApplication] openURL:url]; // iOS <10
            }
        }
    }
    else
    {
        [self createInteraction:[NSNumber numberWithInt:1] stringTracking:trackingIdString];
    }
}
```

## Send events in iOS

To send events, use the following sample code snippet:

```
- (void) createInteraction: (NSNumber *) typeInteraction stringTracking:(NSString *)trackingId
{
    if([trackingId isEqual:@"00000000-0000-0000-0000-000000000000"]){
        return;
    }
    NSString* orgId = [[NSUserDefaults standardUserDefaults] objectForKey:@"organizationId2"]
    NSString* endP = [[NSUserDefaults standardUserDefaults] objectForKey:@"endpoint2"];
    
    if(orgId == NULL || endP == NULL){
        return;
    }
    
// Create open interaction
    NSMutableURLRequest *urlRequest = [[NSMutableURLRequest alloc] initWithURL:[NSURL URLWithString:[NSString stringWithFormat: @"https://%@/api/v1.0/orgs/%@/pushchannel/event/trackings/%@", endP, orgId, trackingId]]];

// Create the Method "GET" or "POST"
    [urlRequest setHTTPMethod:@"POST"];
    [urlRequest setValue:@"application/json" forHTTPHeaderField:@"Content-Type"];
    [urlRequest setValue:@"application/json" forHTTPHeaderField:@"Accept"];

// Convert the String to Data
    NSString *deviceToken = [[NSUserDefaults standardUserDefaults] objectForKey:@"deviceToken"];
    NSDictionary *jsonBodyDict = @{@"PushNotificationStatus":typeInteraction, @"DeviceToken":deviceToken};
    NSData *data = [NSJSONSerialization dataWithJSONObject:jsonBodyDict options:kNilOptions error:nil];

// Apply the data to the body
    [urlRequest setHTTPBody:data];
    NSURLSession *session = [NSURLSession sharedSession];
    NSURLSessionDataTask *dataTask = [session dataTaskWithRequest:urlRequest completionHandler:^(NSData *data, NSURLResponse *response, NSError *error) {
        NSHTTPURLResponse *httpResponse = (NSHTTPURLResponse *)response;
        
        if(httpResponse.statusCode == 200)
        {
            NSLog(@"Login SUCCESS");
        }
        else
        {
            NSLog(@"Error %ld", (long)[httpResponse statusCode]);
        }
    }];
    [dataTask resume];
}
```

## Receive notifications in Android

Events are used for tracking notifications as follows:

- **Opened:** User tapped on the notification.
- **Clicked:** User clicked on the link within the notification.

**EventTrackingContract**

**JSON Body:**

```
{
    "PushNotificationStatus": "Opened",
    "DeviceToken": {deviceToken}
}
```

**Endpoint URL:**

```
{PublicEndpoint}api/v1.0/orgs/<orgId>/pushchannel/event/trackings/<trackingId>
```

- **OrgId:** This is the id for your organization, generated when you registered with Dynamics CRM.
- **TrackingId:** Every notification has a tracking id in its data. This id needs to be sent for event tracking.

### Sample code snippet to parse the incoming notifications in Android

#### Part 1: Obtaining the tracking ID from the notification message

Override the **OnMessageReceived** method of **FirebaseMessagingService** and extract the required data from the payload as shown:

```
@Override
    public void onMessageReceived(RemoteMessage remoteMessage) {
        
// Not getting messages here? See why this may be: https://goo.gl/39bRNJ
        Log.d(TAG, "From: " + remoteMessage.getFrom());
        String message = null;
        String title = null;
        String deepLink = null;
        String name = null;
        String trackingId = null;
        
// Check if message contains a notification payload.
        if (remoteMessage.getNotification() != null) {
            message = remoteMessage.getNotification().getBody();
            title = remoteMessage.getNotification().getTitle();
        }
        
// Check if message contains a data payload.
        if (remoteMessage.getData().size() > 0) {
            if (remoteMessage.getData().get("title") != null) {
                title = remoteMessage.getData().get("title");
            }
            if (remoteMessage.getData().get("body") != null) {
                message = remoteMessage.getData().get("body");
            }
            
// If tracking consent has been taken, use link otherwise use 'originalLink'
            if (remoteMessage.getData().get("link") != null) {
                deepLink = remoteMessage.getData().get("link");
            }
            if (remoteMessage.getData().containsKey("trackingId")) {
                trackingId = remoteMessage.getData().get("trackingId");
            }
        }
        if (message != null || title != null) {
            sendNotification(message, title, deepLink, name, trackingId);
        } else {
            Log.d(TAG, "Empty Notification Received");
        }
    }
```

#### Part 2: Create a notification

Create the notification content and add the tracking ID in the data to generate the event on notification open.

```
private void sendNotification(String message, String title, String deeplink, String name, String trackingId) {
    NotificationManager notificationManager = (NotificationManager)
        this.getSystemService(Context.NOTIFICATION_SERVICE);

    Uri defaultSoundUri = RingtoneManager.getDefaultUri(RingtoneManager.TYPE_NOTIFICATION);
    NotificationCompat.Builder notificationBuilder = new NotificationCompat.Builder(
        this,
        NOTIFICATION_CHANNEL_ID)
        .setContentText(message)
        .setContentTitle(title)
        .setPriority(NotificationCompat.PRIORITY_HIGH)
        .setSmallIcon(android.R.drawable.ic_popup_reminder)
        .setBadgeIconType(NotificationCompat.BADGE_ICON_SMALL)
        .setContentIntent(createContentIntent(this, deeplink, name, trackingId))
        .setDeleteIntent(createOnDismissedIntent(this, trackingId))
        .setStyle(new NotificationCompat.BigTextStyle()
            .bigText(message));

    notificationManager.notify(NOTIFICATION_ID, notificationBuilder.build());
}

private PendingIntent createOnDismissedIntent(Context context, String trackingId) {
    Intent intent = new Intent(context, NotificationDismissalReceiver.class);
    intent.putExtra("TrackingId", trackingId);

    return PendingIntent.getBroadcast(context.getApplicationContext(),0, intent, 0);
}

private PendingIntent createContentIntent(Context context, String deeplink, String name, String trackingId) {
    Intent intent;

    if (deeplink != null) {
        intent = new Intent(Intent.ACTION_VIEW, Uri.parse(deeplink));
    } else {
        intent = new Intent(this, MainActivity.class);
    }
    Bundle pushData = new Bundle();
    pushData.putString("name", name);

    intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
    intent.putExtras(pushData);
    intent.putExtra("Source", "Notification");
    intent.putExtra("TrackingId", trackingId);

    return PendingIntent.getActivity(this, NOTIFICATION_ID, intent, PendingIntent.FLAG_ONE_SHOT);
}
```

#### Part 3: Generate a notification opened event

Handle the application open through the notification in **MainActivity** to obtain the tracking ID.

```
@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        String source = getIntent().getStringExtra("Source");
        if (source != null && !source.isEmpty())
        {
            String trackingId = getIntent().getStringExtra("TrackingId");
            EventTrackerClient.sendEventToServer(this.getApplicationContext(), trackingId, EventType.Opened);
        }
        checkPlayServices();
        FirebaseService.createChannelAndHandleNotifications(getApplicationContext());
```

## Send events in Android

To send events, use the following sample code snippets:

### Part 1: Generate the payload

```
EventTrackingContract:
public class EventTrackingContract {
    private static final String LOG_TAG = "DeviceRegistrationContract";
    private EventType mEvent;
    private String mDeviceToken;
    public EventTrackingContract(EventType eventName, String deviceToken) {
        this.setEventName(eventName);
        this.setDeviceToken(deviceToken);
    }
    public EventType getEventName() {
        return mEvent;
    }
    public void setEventName(EventType eventName) {
        this.mEvent = eventName;
    }
    public String getDeviceToken() {
        return mDeviceToken;
    }
    public void setDeviceToken(String deviceToken) {
        this.mDeviceToken = deviceToken;
    }
    public String toJsonString() {
        JSONObject jsonObject = new JSONObject();
        try {
            jsonObject.put("PushNotificationStatus", mEvent.toString());
            jsonObject.put("DeviceToken", mDeviceToken);
        } catch (JSONException e) {
            Log.d(LOG_TAG, "Json exception while creating event tracking contract: " + e.getMessage());
        }
        return jsonObject.toString();
    }
}

EventTypeEnum:
public enum EventType {
    Clicked(0),
    Opened(1);

    private int value;

    private EventType(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }
}
```

### Part 2: HttpClient for sending the event to the server

```
AsyncTask.execute(new Runnable() {
            @Override
            public void run() {
                SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context);
                String hostname = sharedPreferences.getString(HOST_NAME, "");
                String organizationId = sharedPreferences.getString(ORGANIZATION_ID, "");
                final HashMap<String, String> headers = new HashMap<>();
                headers.put("Content-Type", "application/json");
                final EventTrackingContract eventTrackingContract = new EventTrackingContract(event);
                Log.d(TAG, eventTrackingContract.toJsonString());
                String response = HttpClientWrapper.request(String.format(NotificationSettings.CxpTrackEventUrl, hostname, organizationId, trackingId),
                        "POST", headers, eventTrackingContract.toJsonString());
                Log.d(TAG, response);
            }
        });
```

[!INCLUDE[footer-include](../includes/footer-banner.md)]