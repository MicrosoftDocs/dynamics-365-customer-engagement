---
title: "Use Connected Field Service to remotely monitor and service customer equipment (Dynamics 365 for Field service) | MicrosoftDocs"
ms.custom:
  - dyn365-fieldservice
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: 2142d996-008b-4ada-bf2e-e9dc316715c4
caps.latest.revision: 14
ms.author: krbjoran
manager: shellyha
---
# Use Connected Field Service to remotely monitor and service customer equipment (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use [!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] to monitor connected devices and always know your customer’s equipment is functioning correctly. If equipment fails, you’ll be notified so that you can troubleshoot the problem remotely, or send a technician to fix it.  
  
 [!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)] helps service organizations move from a costly break-fix model to a more proactive service model by combining monitoring and predictive maintenance with Internet of Things (IoT).  
  
 Key benefits of Connected Field Service:  
  
-   Reduce downtime with proactive alerts from connected devices.  
  
-   Address issues faster by remotely monitoring devices and keeping customers in the loop.  
  
-   Reduce maintenance costs by dispatching a technician with the right expertise, availability, and location to the job.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_2016_update_d365_online](../includes/cc-feature-included-with-update-2016.md)]  <!-- This may be the incorrect token. It was added to fix a build issue. -->  
  
 To learn more, see ![Video button](../field-service/media/video-button.PNG "Video button")[Video: Use Connected Field Service to remotely monitor and service customer equipment (2:59)](http://go.microsoft.com/fwlink/p/?LinkID=830138)  
  
<a name="bkmk_prereq"></a>   
## Prerequisites  
 Before you install [!INCLUDE[pn_connected_field_service_msdyn365](../includes/pn-connected-field-service-msdyn365.md)], make sure you have the following:  
  
-   [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] solution. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Install Dynamics 365 for Field Service](../field-service/install-field-service.md)  
  
-   O365 Global Administrator or Dynamics 365 System Administrator credentials.  
  
-   An IoT – Administrator role in the IoT solution (to access IoT entities and IoT functionality), plus another role, like Field Service – Dispatcher (to access Dynamics 365).  
  
-   An active Azure subscription. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What is Azure?](https://azure.microsoft.com/en-us/overview/what-is-azure)  
  
-   Microsoft Power BI PRO and the sample report template. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Download the Power BI Template for Connected Field Service](http://download.microsoft.com/download/E/B/5/EB5ED97A-A36A-4CAE-8C04-333A1E463B4F/PowerBI%20Report%20Template%20for%20Connected%20Field%20Service%20for%20Microsoft%20Dynamics%20365.pbix)  
  
<a name="bkmk_install"></a>   
## Install Connected Field Service  
 Install the Connected Field Service solution from your Office 365 admin portal. The solution includes a sample thermostat simulator app that you can use to send test alerts to connected devices that are registered in field service.  
  
 Developers can also use the simulator as a sample template to further customize the app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Connected Field Service Developer Guide](https://msdn.microsoft.com/en-us/library/mt790241.aspx)  
  
1.  Sign in to [https://portal.office.com](https://portal.office.com) with your Global Administrator or Dynamics 365 system administrator credentials.  
  
2.  Click **Admin centers** > **Dynamics 365**  
  
3.  Click the **Applications** tab, and then select **Connected Field Service**.  
  
4.  Click **Manage**.  
  
5.  Read and accept the **Terms of service**.  
  
6.  In the **Installing Azure Required Assets** dialog box, enter your Azure account, click **Sign In User**, and then  follow the sign-in process.  
  
7.  In the **Selecting Azure Subscription** dialog box, select the Azure subscription that you want to create resources under and then click **Next**.  
  
8.  In the **Choose a resource group** dialog box, create a new resource group or use an existing resource group.  
  
9. **Optional Step for Power BI**.  To install the Azure SQL database that is used for Power BI, check the **Enable Power BI Integration** box, and then enter the Azure SQL database user name and password.  
  
    > [!NOTE]
    >  To Power BI, you will also need to download a PBIX (PowerBI desktop file) to publish reports.  
  
10. Click **Deploy**.  
  
 After you’ve installed all required Azure resources, click **Authorize** to configure the Dynamics 365 connector connection API . When you configure the connection API you’ll need to enter your Dynamics 365 subscription account.  
  
> [!NOTE]
>  Before you click the **Authorize** button, make sure all required Azure resources are successfully deployed and that the overall deployment status is “Success”.  
  
### Set up the sample simulator (optional)  
 To find the simulator URL , sign in to your Azure subscription, and then click the App Service resource type under the newly created resource group. You’ll see the URL is in the top right corner. Copy the URL and complete the following steps:  
  
1.  Paste the URL into your browser’s address bar to load the page.  
  
2.  When the simulator page opens, click **Configuration**.  
  
3.  Enter the IoT hub host name and key. This information is in your Azure portal.  
  
4.  Select the IoT hub in the **Resource Group**.  
  
5.  On the left under **General**, click **Shared access policies** to get the host name and primary key.  
  
6.  Make sure **Connection status**  is marked as **Connected** and then close the dialog box.  
  
 Now you can send a test command by using the sample simulator. For example, click the temperature and increase it to  above 70 degrees.  
  
<a name="bkmk_register"></a>   
## Register devices that you want to monitor in Dynamics 365  
 To monitor a device, you need to create and register an asset.  
  
1.  From the main menu  click, **Field Service** > **Customer Assets**.  
  
2.  On the command bar click **New**.  
  
3.  Use the helpful tooltips to fill in information.  
  
4. **Connected Device Attributes**: to register the device with the IoT hub, make sure you enter a **Device ID**.  
  
5.  When you’re done, click **SAVE** and a record will be created.  
  
6.  On the command bar click, **REGISTER DEVICES**.  
  
7.  Click **OK** in the registration box that appears.  
  
8.  When the device is registered, it will appear as a registered asset. To verify the registration, from the main menu click **Field Service**  > **Registered Assets**.  
  
### Set up a Power BI chart (optional)  
 Set up Power BI  accounts and open the sample .pbix report.  
  
1.  Go to [https://powerbi.microsoft.com](https://powerbi.microsoft.com) and create a free Power BI account .  
  
2.  [Install Power BI Desktop](https://powerbi.microsoft.com/en-us/desktop/).  
  
3.  Sign in to Power BI Desktop with the Power BI user credentials (we recommend that this user is the same as the Dynamics 365 user).  
  
4.  Download and open the sample Power BI template.  
  
 The Power BI report will open with errors because it was created with a sample SQL database and user. Update the query with your SQL database and user, and then publish the report to Power BI.  
  
#### Update the query to point to your SQL database  
  
1.  Click **Edit Queries**.  
  
2.  Click **Advanced Editor**.  
  
3.  Replace the source SQL database with the database provisioned in your Azure resource group.  
  
4.  Click **Close and Apply**.  
  
     You can find your SQL server name in the SQL database in the Azure portal.  
  
5.  Add your IP address to the SQL server firewall to allow Power BI Desktop to connect to the SQL server.  
  
6.  Copy the IP address when you see this message.  
  
 ![Microsoft SQL message](../field-service/media/do-not-use3.png "Microsoft SQL message")  
  
7.  Go to the Azure portal, open the SQL server, and add your IP address to the firewall.  
  
#### Publish to your Power BI account  
  
1.  Save your changes and publish.  
  
2.  Once you publish, Power BI Desktop will provide a link and message that instructs you to open the report and provide credentials.  
  
3.  Once the report is open, you’ll see notifications to edit your credentials.  
  
4.  Enter the SQL server admin user name and password to allow Power BI to access your database.  
  
5.  In the Power BI  sidebar, open the report and pin these tiles to a dashboard. You can create a dashboard or pin to an existing one.  
  
6.  Save the dashboard, and then share it with any users who have permissions to see the dashboard and tiles.  
  
    -   In the top right corner of the dashboard, click **Share**, enter the users email address, and click the **Share** button .  
  
#### Pin the tile in Dynamics 365  
  
1.  Open the device, alert, or asset form.  
  
    > [!IMPORTANT]
    >  The device that is related to any of the open forms must have a device ID and be registered; otherwise, the PowerBI section will be hidden.  
  
2.  The first time you  will need to specify the tile you want pinned. After that, the tile will load when you go to the page.  
  
    1.  Click the **Add** button.  
  
    2.  A configuration window displays. Sign in if prompted.  
  
    3.  Pick your dashboard and tile.  
  
         A preview of the tile will load; however, if you have not run the simulator for that device, there will be no data, as shown here.  
  
3.  Save the tile.  
  
4.  The config window closes, and the Power BI section reloads with the pinned tile.  
  
5.  The tile is filtered to the device ID of the current entity.  
  
6.  The next time you load any of the device, alert, or asset forms, the Power BI section will load the tile automatically, filtered to the current entity device ID (if there is a device ID and the device has been registered).  
  
### Add devices to an asset  
 If you have a device with more parts that you want to monitor, instead of creating separate asset records for each part, you can create one asset record and add the parts to it.  
  
1.  From the main menu click **Field Service** > **Registered Assets**.  
  
2.  From the list of existing assets, open the asset record that you want to add parts to.  
  
3.  To add parts, in the **Connected Devices** section, click the **See the records associated with this view** button.  
  
4.  Click **Connect**, and then click **To Another** or **To Me**.  
  
5.  Use the helpful tooltips to fill in the rest of the information and then click **Save**.  
  
### Register multiple existing assets  
  
1.  To register multiple assets at once, click **Field Service** > **Customer Assets**.  
  
2.  From the list of assets, select the assets that you want to register.  
  
3.  On the command bar, click **REGISTER DEVICES.**  
  
4.  Click **OK** in the registration dialog box that appears.  
  
5.  When the device is registered, it will show up as a registered asset. To verify the registration, from the main menu click **Field Service** > **Registered Assets**.  
  
### Register an asset on the mobile app  
 Before you can register assets on the mobile app, you will first need to install the mobile app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Field Service Mobile App User’s Guide](../field-service/field-service-mobile-app-user-guide.md)  
  
1.  On your mobile device, open the mobile app.  
  
2.  Tap **Customer Assets**, and then tap the **Add** button.  
  
3.  Fill in the asset information and, then  tap **Register Device**.  
  
> [!NOTE]
>  You cannot associate an asset with a device using the mobile app.  
  
### Registration error  
 When a device does not register, you will see an error in the Registration Status field of the asset record. For assets with multiple devices, device status will show the error message for each device.  
  
 This error may occur if Dynamics 365 is not connected to Azure or if Azure is offline.  
  
### View a device's registration history  
  
1.  From the main menu, click **Internet of Things** > **Registered Devices**.  
  
2.  Click an IoT device record to open it.  
  
3.  In the Category field, use the search button to find and to add the device to a category.  
  
<a name="bkmk_Categorize"></a>   
## Categorize devices  
 You can also manage devices by categorizing them. For example, you can categorize devices by the commands they support, the type of device, or by devices that break down more often.  
  
### Create a new IoT device category  
  
1.  From the main menu, click **Internet of Things** > **Device Categories**.  
  
2.  On the command bar, click **New**.  
  
3.  Enter a **Name** for the device category.  
  
4.  Use the helpful tooltips to fill in information.  
  
5.  When you're done click **Save**.  
  
6.  Open the IoT device category record that you created.  
  
7.  In the **Devices** section, click **Add IoT Device record** , and  then add a device to the category.  
  
### Add devices to an existing category  
  
1.  From the main menu click, **Internet of Things** > **Registered Devices**.  
  
2.  Click an IoT device record to open it.  
  
3.  In the **Category** field, use the search button to find and add the device to a category.  
  
<a name="bkmk_deviceReading"></a>   
## View device readings  
 Once a device is registered, you can open the record to view the readings sent by the device. For example, if you’re monitoring a thermostat, your reading will show the thermostat temperature.  
  
 By default, you can view the last 20 readings. You can change the default setting in the Power BI report by using Power BI Desktop.  
  
1.  To view a device reading, from the main menu, click **Field Service** > **Customer Asset**.  
  
2.  From the list of assets, choose an asset and open the record.  
  
3.  Refer to the **Connect Device Readings** section to view the device readings.  
  
<a name="bkmk_remotely"></a>   
## Remotely send commands to a registered device  
 When a device isn’t working properly, the system receives an alert. To troubleshoot the issue remotely, you can send a command by choosing a registered device or by using an existing IoT alert.  
  
> [!NOTE]
>  When you receive multiple alerts from the same device, the alerts will be listed in hierarchical order. You can change the grouping by changing the IoT - Parent IoT Alerts workflow.  
  
### Send commands from a registered asset  
  
1.  From the main menu, click **Field Service** > **Registered Assets**.  
  
2.  From the list of assets, choose a registered asset or device.  
  
3.  On the command bar, click **CREATE COMMAND**.  
  
4.  Enter a **Name** for the command.  
  
5.  In the **MESSAGE TO SEND** box, copy and paste one of these supported commends. `{"CommandName":"Reset Thermostat","Parameters":{}}` `{"CommandName":"Notification","Parameters":{"Message":"Technician has been dispatched"}}` `{"CommandName":"Set Values","Parameters":{"Reading":{"Temperature":"30","Humidity":"30"}}}`  
  
    > [!NOTE]
    >  Before sending a command make sure there are no spaces or extra characters in the command.  
  
6.  On the command bar, click **SEND&CLOSE** to send the command.  
  
### Respond to an alert  
  
1.  Navigate to **Field Service** > **IoT Alerts**.  
  
2.  Choose an existing IoT alert record.  
  
3.  On the command bar, click **CREATE COMMAND**.  
  
4.  Enter a **Name** for the command.  
  
5.  In the **MESSAGE TO SEND** box, copy and paste one of the supported commands listed section above.  
  
6.  On the command bar, click **SEND&CLOSE** to send the command.  
  
### View history of commands sent to a device  
  
1.  From the main menu, click **Field Service** > **Customer Assets**.  
  
2.  From the list, choose an asset.  
  
3.  Scroll down to the **Command** section to view the history.  
  
<a name="bkmk_bussinessFlow"></a>   
## Create business process flows to automatically handle incoming IoT alerts  
 When you receive an alert from a device, your service team can manually monitor the alerts and troubleshoot the issue remotely. If the issue is not resolved by sending a remote command, the service rep can create a case or work order and dispatch a field tech. The provided business process flow guides you through the process of manually responding to IoT alerts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create a business process flow](../customize/create-business-process-flow.md)  
  
 List of default IoT actions:  
  
-   IoT- Parent IoT Alerts (Action)  
  
-   IoT- Register Customer Entity (Action)  
  
-   IoT- Register Device (Action)  
  
-   IoT – Debounce IoT Alerts (Action)  
  
-   JSON-Based Field Value - Get Number (Action)  
  
-   JSON-Based Field Value - Get String (Action)  
  
-   JSON-Based Field Value - Get Boolean (Action)  
  
<a name="bkmk_IOTDashboard"></a>   
## View the IoT dashboard  
 The default IoT dashboard provides data on registered devices and alerts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or customize dashboards](../customize/create-edit-dashboards.md)  
  
1.  From the main menu, click **Field Service** or **Internet of Things**.  
  
2.  Click **Dashboard**.  
  
    -   The first chart shows alerts that you can sort by clicking the IoT **Alerts by** menu.  
  
    -   The second chart shows alerts by time.  
  
    -   The third chart shows alerts along with the action taken to resolve the issue.  
  
<a name="bkmk_step3 "></a>   
## Privacy notice  
 [!INCLUDE[cc_privacy_crm_connected_field_service](../includes/cc-privacy-crm-connected-field-service.md)]
  
### See also  
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)    
 [Install Dynamics 365 for Field Service](../field-service/install-field-service.md)   
 [Configure default settings](../field-service/configure-default-settings.md)   
 [View user accounts and security roles](../field-service/view-user-accounts-security-roles.md)<br>
 [Field Service Users Guide](../field-service/user-guide.md) 
