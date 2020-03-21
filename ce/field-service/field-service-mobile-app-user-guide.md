---
title: "Field Service Mobile Setup (Dynamics 365 Field Service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 10/29/2018
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite:
ms.technology:
  - field-service
ms.tgt_pltfrm:
ms.topic: get-started-article
author: FieldServiceDave
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: daclar
manager: shellyha
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365FS
---
# Field Service Mobile Setup

The [!INCLUDE[pn_fieldservice_mobile_app_long](../includes/pn-fieldservice-mobile-app-long.md)] app gives field technicians the information they need to get to a customer location and complete work orders quickly.

 Before field technicians can use the [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] app, a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator needs to install the Field Service Mobile configuration tool and related mobile project.

> [!Note]
> A new mobile app and mobile project has been released for Field Service v7.5.5 and 8.2+.

For more information, visit the [Field Service installation (web + mobile)](../field-service/install-field-service.md) page.

<a name="bkmk_install"></a>

## Install the mobile app on a phone or tablet

To get the mobile app, search and download **Field Service Mobile** from the Windows, Apple, or Google Play app stores, or visit the following links. **Field Service Mobile** requires Field Service versions **7.5.5** or **8.2+**.

- [Download for Windows](https://aka.ms/fsmobile-windows)
- [Download for iOS (Apple)](https://aka.ms/fsmobile-iOS)
- [Download for Android](https://aka.ms/fsmobile-android)

  ![Download the Field Service Mobile app](../field-service/media/mobile-field-service-mobile-windows-app-store.png "Download the Field Service Mobile app")

  > [!Note]
  > To use Field Service Mobile, the bookable resource (field technician) record must have **Enabled for Field Service Mobile** set to **Yes**.

<a name="bkmk_signin"></a>
## Sign in and sync data

 To sign in, you need your organization's Dynamics 365 URL, your user name, and password. Contact your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator if you don't have this information. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md).  
  
1. Open the app, and enter your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] credentials. When sign in completes, you'll see the Home screen. 
  
  
   ![Home screen in the Field Service Mobile app](../field-service/media/field-service-mobile-home-screen.PNG "Home screen in the Field Service Mobile app")  
  
2. To sync your device to the server, tap the **Sync** button to download changes made on the server to your phone or tablet, and upload information from your device to the server.  
  
   ![Sync the Field Service Mobile app device](../field-service/media/field-service-sync-mobile-device.PNG "Sync the Field Service Mobile app device")  
  
<a name="bkmk_online"></a>   
## Work online or offline  
 [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile) lets you work online or offline. Online mode requires an Internet connection; offline mode does not.  
  
 The system administrator configures the app to sync when it launches, when information changes, or every few minutes.   
  
### Online mode  
 When you’re working online, information continuously syncs with the server, so you don’t need to manually sync your device.  
  
- To work online, tap the Online/Offline mode button.  The screenshot shows how the button looks when you’re online.  
  
  ![Online mode in the Field Service Mobile app](../field-service/media/field-service-online-mode.PNG "Online mode in the Field Service Mobile app")  
  
### Offline mode  
 When you're working offline, the information you need is downloaded to your device. This way you can continue your work even without an Internet connection. When you enter information, it’s saved to your device and sent to the server on the next sync.  
  
- To work offline, tap the Online/Offline Mode button.  The screenshot shows how the button looks when you’re offline.  
  
  ![Offline mode in the Field Service Mobile app](../field-service/media/field-service-offline-mode.PNG "Offline mode in the Field Service Mobile app")  
  
<a name="bkmk_getaround"></a>   
## Get around the app (for all security roles)  
 When you first sign in to [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile), you’ll see your home screen, which shows you a list of actionable items. To get more information, tap any of the items.  
  
> [!NOTE]
>  If you have a [!INCLUDE[pn_field_service](../includes/pn-field-service.md)] admin, dispatcher,  inventory purchase, or resource (field agent) security role, you can use [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile). However, depending on your security role, you may not have permission to access or change certain data in the app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md)  
  
### Dashboard  
 Your dashboard provides a quick overview of business data. Depending on how things are set up in [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile), you may see a default system dashboard or one that you created. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or customize dashboards](../customize/create-edit-dashboards.md)  
  
 ![Dashboard screen in the Field Service Mobile app](../field-service/media/field-service-dashboard-sceen.PNG "Dashboard screen in the Field Service Mobile app")  
  
### Accounts  
 In Accounts you can see a list of your service accounts.  
  
 To see where all of the accounts are located on a map view, tap the **Map View** button.  
  
 To add a new account, tap the **+**  button, and then add your information.  
  
 ![Account view in the Field Service Mobile app](../field-service/media/field-service-mobile-account-view.PNG "Account view in the Field Service Mobile app")  
  
 Tap an account name to see the account information.  
  
 Tap the **Edit Account** button to edit the account info, such as name, address, and phone number.  
  
 To get more information related to the account, tap any of the buttons at the bottom.  
  
 ![Edit account view in the Field Service Mobile app](../field-service/media/field-service-edit-account-view.PNG "Edit account view in the Field Service Mobile app")  
  
### Bookable resources  
 In Bookable Resources shows your work order bookings.  
  
 By default, work orders are listed in the **Agenda** view. To change views, tap **Day**, **Week**, or **Month**.  
  
 ![Bookable Resource Bookings in the agenda view](../field-service/media/field-service-booking-view.PNG "Bookable Resource Bookings in the agenda view")  
  
### Contacts  
 Contacts shows a list of all your account contacts.  
  
 To see where your contacts are located on a map, tap the **Map** button.  
  
 To add a new contact, tap the **+** button, and then add your information  
  
 ![Contact view in the Field Service Mobile app](../field-service/media/field-service-contact-view.PNG "Contact view in the Field Service Mobile app")  
  
 Tap a contact’s name to see the account information.  
  
 Tap the **Edit** button to edit the contact's info, such as name, email address, and phone number.  
  
 To get more information about the contact, tap any of the buttons at the bottom.  
  
 ![Edit a contact](../field-service/media/field-service-edit-contact.PNG "Edit a contact")  
  
### Customer assets  
 In Customer Assets you'll see which products a customer uses.  
  
 To add new customer assets, tap the **+**  button, and then add the asset information.  
  
 ![Add new customer asset](../field-service/media/field-service-customer-asset.PNG "Add new customer asset")  
  
 To see information related to the asset, tap the asset name on the left.  
  
 ![Edit customer assets](../field-service/media/field-service-edit-customer-assets.PNG "Edit customer assets")  
  
### Products  
 Products shows a list of your products, including the price, type of product, quantity on hand, and more.  
  
 To add a new product, tap the **+**  button, and then add the product information.  
  
 ![Add new product](../field-service/media/field-service-add-new-product.PNG "Add new product")  
  
 To see details about the product, tap **Products**, and then tap a product in the list.  
  
 ![View more product info](../field-service/media/field-service-view-more-porduct-info.PNG "View more product info")  
  
### Agreements  
 Agreements is where you can see customer contracts.  
  
### Time off requests  
  
1. If you need to take time off or you are not available to take a new work order, tap **Time Off Requests**, and then tap the **+**  button.  
  
2. Fill in your time off information, and then tap the Save button.  
  

   > [!NOTE]
   >  This will gray your name out on the schedule board, which lets the dispatcher and scheduling assistant know that you aren't available.

   ![Request time off](../field-service/media/field-service-request-time-off.PNG "Request time off")

### Map
 The map shows the location of your accounts and contacts on a map.

 To filter the view, tap **Accounts** or **Contacts**.

> [!div class="mx-imgBorder"]
> ![Map view](../field-service/media/field-service-map-view.png "Map view")

### Calendar
 The calendar shows your appointments on a calendar.

### Change settings and sign-in info
 To see or update your setup or sign-in information, tap **Setup**.

### About this version
 To see which version of the app you’re using, tap **About**.

 Tap the **Menu** button in the top right to send logs, view privacy info, and more.

 ![About the Field Service Mobile app device](../field-service/media/field-service-about-mobile-device.PNG "About the Field Service Mobile app device")

<a name="bkmk_fieldagents"></a>
## Review work order bookings
 When a work order is assigned to you, it shows up in [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile).

 By default, you can only see work orders for the current day plus the next 7 days, that have a status of scheduled, traveling, or in progress. Once a work order is completed, you can no longer see it in [!INCLUDE[pn_fieldservice_mobile_app_short](../includes/pn-fieldservice-mobile-app-short.md)] (mobile).

1. To see your work order bookings, tap **Bookable Resource Booking**.

2. By default, work orders are listed in the **Agenda** view. To change views, tap **Day**, **Week**, or **Month**.

   ![Bookable Resource Bookings in the agenda view](../field-service/media/field-service-booking-view.PNG "Bookable Resource Bookings in the agenda view")

   You can also tap the Arrow button to see your bookings for the next day. Or, you can use the  filter to see work orders with a specific booking status.

   ![Booking info view](../field-service/media/field-service-book-view-info.PNG "Booking info view")

## Open a work order

1. To open a work order, from the list of bookings, tap the work order that you want to open. The work order opens on the right.

2. To open the work order in full screen view, at the top, double-tap **Work Order**.

   ![View work order](../field-service/media/field-service-view-work-order.PNG "View work order")

## See the location of a work order on a map

1. Open the work order, and then tap **Map**. This shows the location of the work order on a map.

2. To get driving directions, tap the Driving Direction button. This opens the default driving directions app on your mobile device. It provides turn-by-turn directions from your location to the work order location.

   ![Work order map view](../field-service/media/field-service-work-order-map-view.PNG "Work order map view")

## Update work order status
 The minute you start driving to the next job, it’s important to update the status of the work order. This keeps the dispatcher up to date on what’s going on with the work order, and lets the dispatch team provide the customer with the current status.

1. Open the work order, and then tap **Booking**.

2. Tap Add button for **Booking Status**.

3. Select a status. If you’re driving to the work order location, then update your status to **Traveling**.

   ![Update booking status](../field-service/media/field-service-update-booking-status.PNG "Update booking status")

   > [!NOTE]
   >  Make sure to update the status again when you arrive on site, and again when you complete the work order.

4. When you’re done, tap the **Save** button.

   > [!NOTE]
   >  When the work order is complete, remember to mark it as **Completed**.

## Update work order start time
 When a dispatcher schedules a work order, the booking will have a start and end time. This may be the time promised to the customer, but if you’re running late or the job is taking longer than expected, it’s important to update the start and end time. This automatically keeps the dispatcher up to date on the schedule board.

- Open the work order, tap **Booking**, and then change the **Start Time**.

  ![Update work order start time](../field-service/media/field-service-update-start-time.PNG "Update work order start time")

## Check work order details
 To get more information on what work needs to be done for the service call, look at the **Info**, **Other**, and **Incidents** tabs.

 The **Info** tab provides service account info, address, priority, and more.

 ![Work order Info tab](../field-service/media/field-service-info-tab.PNG "Work order Info tab")

 The **Other** tab provides billing account info, service time windows, price lists, and more.

 ![Work order Other tab](../field-service/media/field-service-other-tab.PNG "Work order Other tab")

 The **Incidents** tab shows which incidents are linked to the work order.

 ![Work order Incidents tab](../field-service/media/field-service-incidents-tab.PNG "Work order Incidents tab")

## Check service tasks, products, and services
 When a work order is created, incidents are added to the work order, which includes a list of service tasks, products, and services.

 Service tasks let a field agent know what tasks need to be performed for the work order. Products tell them what products they might have to use to complete the work order. Services show the hours needed to complete the work.

**Check service tasks**

1. Open the work order, and then tap **Service Tasks**.

   ![List of service tasks](../field-service/media/field-service-list-service-tasks.PNG "List of service tasks")

2. Tap a service task to open it.

3. When the service task is open, add notes, mark percentage complete, and how long it took to complete the task.

   ![Work Order Service Task details view](../field-service/media/field-service-service-task-details-view.PNG "Work Order Service Task details view")

4. When you’re done tap, the **Save** button.

**Check products**

1. Open the work order, and then tap **Products**.

2. Tap a product name to open it.

   ![List of products](../field-service/media/field-service-list-products.PNG "List of products")

3. Mark if the product was used, enter the correct quantity, make sure the price is correct, and add any additional notes.

   ![Mark product as used](../field-service/media/field-service-mark-product-used.PNG "Mark product as used")

4. When you’re done, tap the **Save** button.

**Check services**

1. Open the work order, and then tap **Services**.

2. Tap a service name to open it.

   ![List of labor service](../field-service/media/field-service-list-labor-service.PNG "List of labor service")

3. If the service was performed, mark it as used, and then add any additional information.

   ![Mark service as used](../field-service/media/field-service-mark-service-used.PNG "Mark service as used")

4. When you’re done, tap the Save button.

## Add notes, pictures, signatures, and more
 When you’re working on a work order you can add your notes, attachments, pictures, and signatures.

**Add a picture**

1. Open the work order, tap **Notes**, and then tap the **Camera** button.

   ![Add picture](../field-service/media/field-service-add-picture.PNG "Add picture")

2. Tap the **Camera** button to take the picture

3. Adjust the picture as needed, and when you’re done, tap the Save button.

**Add notes**

1. Open the work order, and then tap **Notes**.

2. To add notes, tap the **Add** button **+**  .

   ![Add notes in the Field Service Mobile app](../field-service/media/field-service-add-notes.PNG "Add notes in the Field Service Mobile app")

3. Add your notes in the **Description** area.

   ![Type notes in field service](../field-service/media/field-service-type-your-notes.PNG "Type notes in field service")

4. When you’re done, tap **Save**.

**Add attachments, signatures, record video, and more**

1. Open the work order, and then tap **Notes**.

2. Tap the **Add** button **+**  .

3. Tap the **Menu** button to add attachments, signatures, record video and more.

   ![Add attachments and signatures](../field-service/media/field-service-add-attachments-signature.PNG "Add attachments and signatures")

4. When you’re done, tap **Save**.

## Create a follow-up booking
If work still needs to be done, you can create a follow-up booking.

1. Open the work order, and then tap **Booking**.

2. Tap the **Menu** button , and then tap **Create follow up**.

   ![Create a follow up](../field-service/media/field-service-create-follow-up.PNG "Create a follow up")

3. Tap **Open**, and then add your information

4. When you’re done, tap **Save**.

### Next Steps
- [Enable Bookable Resources for mobile app access](set-up-bookable-resources.md)

### See also

- [Dynamics 365 Field Service - User's Guide](../field-service/user-guide.md)

- [Overview of Dynamics 365 Field Service](../field-service/overview.md)
