# Mobile

## What is the latest version of the mobile app and related Woodford version?

The latest version of the Field Service Mobile (2017) app is 9.1 and this corresponds to Woodford version 9.1.

You can view the version of your mobile app in the About section

![Mobile FAQs image1](media/Mobile-FAQs-image1.png)

In the October 2018 release of Field Service, the mobile app will be updated to 11.1 and will correspond to Woodford version 11.1.

![Mobile FAQs image2](media/Mobile-FAQs-image2.png)

**Pro Tip:** You can download the latest version of Woodford and simply publish to a previous version that is compatible. As an example, the org in the picture below has Woodford 11.1 installed but the mobile project is published to 9.1 to accommodate the 9.1 release of the Field Service mobile (2017). This is advantageous because when Field Service 11.1 is released you will not need to update Woodford.

To view your Woodford solution version, in a non-private Internet Explorer navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

![Mobile FAQs image4](media/Mobile-FAQs-image4.png)

Within the mobile project…

![Mobile FAQs image5](media/Mobile-FAQs-image5.png)

## My mobile app will not sync to the server or it crashes immediately

There are multiple reasons a user may not be able to sync his mobile application to the server or why the application crashes immediately.

1.  Incorrect URL, username, or password. **This is the most common reason**.

2.  There is no mobile project in Woodford, or the mobile project is unpublished

3.  The mobile project is published to a later version than the mobile app

4.  Your user does not have the correct security role to access the mobile application

### Incorrect URL, username, or password. **This is the most common reason**. 

Edit the URL, username, and password in Setup. Note the username and password are case sensitive.

![Mobile FAQs image6](media/Mobile-FAQs-image6.png)  

### There is no mobile project in Woodford, or the mobile project is unpublished

To fix this, in a non-private Internet Explorer browser as an administrator, navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford** and verify a mobile project exists. A blue circle indicates it is published.

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

![Mobile FAQs image7](media/Mobile-FAQs-image7.png)

**If no mobile project exists**, download and save the template file.

-   If you are on December 2016 Update for Dynamics 365 (online), use this [mobile project template](https://go.microsoft.com/fwlink/p/?linkid=836310)  

-   If you are on Dynamics CRM Online 2016 Update 1, use this [mobile project template](http://go.microsoft.com/fwlink/p/?LinkId=808250)  

**Hint:** You may need to save the template file to a file location on your computer and not the Downloads folder.

Next, import this file into Woodford

![Mobile FAQs image8](media/Mobile-FAQs-image8.png)  

And assign it a name, a priority greater than 0, and assign it to all Field Service security roles

![Mobile FAQs image9](media/Mobile-FAQs-image9.png)  

More details on projects and priorities can be found in the [Woodford Guide](https://www.resco.net/downloads/Woodford_Guide.pdf).  

Finally, double click on the project (template) to view it.

Select **Publish**

### The mobile project is published to a later version than the mobile app

Example: if you are using mobile app version 9.1 but your mobile project in Woodford is published to 9.2+ or the latest.

This results in the “Unsupported metadata version” error

![Mobile FAQs image10](media/Mobile-FAQs-image10.png)  

To fix this, first check the version of your mobile app in the About section

![Mobile FAQs image1](media/Mobile-FAQs-image1.png)

Next, to view your Woodford solution version, in a non-private Internet Explorer navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

And then enter the related mobile project and ensure it is not published to a higher version. In the picture below the mobile project is published to 9.1 which does not exceed the version of our Field Service Mobile (2017) app.

![Mobile FAQs image5](media/Mobile-FAQs-image5.png)

### Your user does not have the correct security role to access the mobile application

When an administrator of the mobile application sets up Woodford, he/she must assign a set of security roles to a mobile project (default configurations). This decides which users get access to the customizations of the project. If a user logs into the mobile app and does not have a security role that corresponds to a published mobile project, the user will not be able to sync to the server.

In a non-private Internet Explorer browser, navigate to **Settings &gt; Woodford MobileCRM Woodford **

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)  

Select and highlight the mobile project your mobile users should have access to and select **Show Users**

![Mobile FAQs image11](media/Mobile-FAQs-image11.png)  

![Mobile FAQs image12](media/Mobile-FAQs-image12.png)  

If the user who cannot sync is not shown here, then he/she does not have access to the mobile project and will not be able to connect.

To fix this, select the mobile project and select **properties** in the header to view security roles who have access to the mobile project

![Mobile FAQs image13](media/Mobile-FAQs-image13.png)  

Then, match the selected security roles above with the user’s security roles in **D365 &gt; Settings &gt; Security &gt; Users**

## My booking is not showing when logged into the mobile app

There are typically 3 reasons bookings are not showing on the mobile app

1.  You need to sync the mobile application to the server and receive data updates

2.  You are in offline mode and the booking is outside the sync filters

3.  Drip scheduling is enabled for the related resource and the booking is outside the *bookings to drip* number parameter

### You need to sync the mobile application to the server and receive data updates

When a dispatcher books a work order to a resource, this takes place on the server and may take time to update on the mobile application. The time it takes for the booking to show on the mobile application can depend on internet speeds, internet connection, and even configurations. As an example, the mobile app can be configured to sync data from the server every X minutes or only when connected to Wi-Fi.

First, try manually syncing data from the server by selecting the sync button.

![Mobile FAQs image14](media/Mobile-FAQs-image14.png)  

If you have trouble syncing, try going to **Setup &gt; Delete Data** &gt; **Save** and sync again.

![Mobile FAQs image15](media/Mobile-FAQs-image15.png)  

Finally, there are scenarios where forcing a full sync to the device can push changes that will allow the user to see bookings. One such scenario is a change in security roles.

To force a full sync to the device, in a non-private Internet Explorer browser as an administrator, navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford.**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

Once in the Woodford interface, navigate to Security, find the user’s device and check Force Full Sync.

![Mobile FAQs image16](media/Mobile-FAQs-image16.png)  

Next, log into the mobile app with the same user and sync the device.

For more information on Forcing Full Syncs, refer to the Woodford guide: <https://www.resco.net/downloads/Woodford_Guide.pdf>

### You are in offline mode in the mobile app and the booking is outside the sync filters

The Field Service mobile application is designed for offline scenarios. This means data is downloaded locally to the device when the user has internet access for later when the user will not have internet access. A common example is performing work in remote areas or in underground tunnels. Rather than download all data, a mobile administrator can create sync filters that will download a targeted portion of the data for offline use later. An example is only downloading this week’s work orders rather than all work orders.

For information on sync filters, refer to the Woodford guide: <https://www.resco.net/downloads/Woodford_Guide.pdf>

There are 2 ways to fix this.

The first way is to use the mobile application in online mode, because this gives you access to all data.

Log into the mobile app and select the online/offline mode icon.

![Mobile FAQs image17](media/Mobile-FAQs-image17.png)  

Select the icon to change it to the following icon to use the application in online mode

![Mobile FAQs image18](media/Mobile-FAQs-image18.png)  

Then navigate to Bookings to view your bookings. Not this may take a few moments to load.

A second way to fix this is to edit sync filters for offline mode.

To edit sync filters for Bookings, in a non-private Internet Explorer browser as an administrator, navigate to **Settings &gt; Woodford &gt; MobileCRM Woodford.**

![Mobile FAQs image3](media/Mobile-FAQs-image3.png)

Enter the mobile project and navigate to **Bookable Resource Bookings &gt; Sync Filters**

![Mobile FAQs image19](media/Mobile-FAQs-image19.png)  

This is where an administrator can decide what Bookings will be downloaded to the mobile application when in offline mode/without internet access.

If your booking is not showing in offline mode, make sure it meets the sync filter criteria or change the sync filter criteria

![Mobile FAQs image20](media/Mobile-FAQs-image20.png)  

### Drip scheduling is enabled for the related resource and the booking is outside the bookings to drip number parameter

Drip scheduling is a feature that only displays the next bookings as current bookings are completed. An example is only displaying the next 2 bookings for a field technician.

One reason you may not see bookings when you log into the mobile app is because drip scheduling may be preventing the booking.

To fix this, navigate to **Field Service &gt; Administration &gt; Resources**

![Mobile FAQs image21](media/Mobile-FAQs-image21.png)  

And find the resource related to the user you are attempting to log into the mobile app with.

![Mobile FAQs image22](media/Mobile-FAQs-image22.png)  

Under the Field Service section, set enable drip scheduling to No, or leave it to Yes and adjust the parameters.

Then log into the mobile application and check if your Bookings are now showing

## Bookings not scheduled to me are showing when logged into the mobile app

This typically means you are logging into the mobile app with a user who has system administrator or Field Service—administrator security roles.

**System administrators** and **Field Service—administrators** have access to all Field Service records including all bookings scheduled to all resources. In contrast, users with the security role **Field Service—resource** only have access to work orders scheduled to that resource and related user.

Ensure your mobile user has only the **Field Service—resource** security role in **Settings &gt; Security &gt; Users &gt; Manage roles**

![Mobile FAQs image23](media/Mobile-FAQs-image23.png)  

**Pro Tip:** Bookings are scheduled to Resources, but User records are used to log into the mobile app. This is made possible because Resources can be tied to User records.
