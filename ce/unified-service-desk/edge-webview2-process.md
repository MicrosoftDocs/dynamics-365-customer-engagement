---
title: "Use the Edge WebView2 Process hosting method for hosting web applications  | MicrosoftDocs"
description: "Learn about the Edge WebView2 Process hosting method and its advantages for hosting your controls in Unified Service Desk."
ms.date: 06/21/2021
ms.topic: "article"
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - customizer
  - developer
ms.custom: 
  - dyn365-USD
monikerRange: '>= dynamics-usd-4.2'
---

# Use Edge WebView2 Process to host web applications



The Edge WebView2 Process browser control hosts your controls in individual Edge WebView2 Process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Microsoft Edge, it'll work in Unified Service Desk.

The advantages of using the Edge WebView2 Process hosting method are as follows:

- Available on supported versions of the Windows operating system
- Highly reliable
- Easy to configure to host applications in Unified Service Desk
- Seamless switching from one browser to another for your entire organization
- Enhanced performance and memory optimization

Also, administrators can perform the following:

- Select Edge WebView2 Process as the hosting type for the organization.
- Select Edge WebView2 Process as the hosting type for select web applications, alongside Chrome Process.

## Edge WebView2 Process settings

You can set Edge WebView2 Process on the hosted controls (existing and new hosted controls) to host applications. This allows you to choose the hosted controls that use Edge WebView2 Process, based on your requirements. More information: [Create a hosted control with hosting type as Edge WebView2](edge-webview2-process.md#create-a-hosted-control-with-hosting-type-as-edge-webview2)

If you want to set Edge WebView2 Process to host the applications for an entire organization, use the **GlobalBrowserMode** Global UII option and specify the value as **EdgeWebView2**. More information: [Enable Edge WebView2 for an entire organization](edge-webview2-process.md#enable-edge-webview2-for-an-entire-organization)

If you want to set Edge WebView2 Process only for some agents in your organization, in the **UnifiedServiceDesk.exe.config** file on their client desktops, add the **GlobalBrowserMode** key with the value of **EdgeWebView2**. More information: [Enable Edge WebView2 for Unified Service Desk on client desktops](edge-webview2-process.md#enable-edge-webview2-for-unified-service-desk-on-client-desktop)

## Enable Edge WebView2 Process

You can enable Edge WebView2 Process in any of the following ways:

- Create an individual hosted control with the Edge WebView2 Process hosting type.
- Enable it for individual client desktops.
- Enable it for an entire organization.

### Order of precedence

- Setting the **GlobalBrowserMode** Global UII option value as **EdgeWebView2** takes precedence over the individual hosted control settings. <br><br>For example, some hosted controls have the hosting type set to **EdgeWebView2**. At the organization level, you set the **GlobalBrowserMode** Global UII option value as **EdgeWebView2**. In this scenario, the Global UII option takes precedence, and the configuration uses the Edge WebView2 Process to host the applications. 

- Setting the **GlobalBrowserMode** key to **EdgeWebView2** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop takes precedence over the individual hosted control settings.<br><br>For example, some hosted controls have their hosting type set to **EdgeWebView2**. For a few agents, you've set the **GlobalBrowserMode** key to **EdgeWebView2** in the **UnifiedServiceDesk.exe.config** file on their client desktops. The value set in the **UnifiedServiceDesk.exe.config** file takes precedence, and the configuration uses Edge WebView2 Process to host the applications.

- Setting the **GlobalBrowserMode** key to **EdgeWebView2** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop takes precedence over other settings.

<a name="create-a-hosted-control-with-hosting-type-as-edge-webview2"></a>

### Create a hosted control with hosting type as Edge WebView2

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. Select **New**.

5. On the **New Hosted Control** page, specify the details, and then select **Edge WebView2 Process** from the **Hosting Type** dropdown list.

   ![Edge WebView2 Process hosted control.](media/edge-webview2-process-hosted-control-setting.PNG "Edge WebView2 Process hosted control")

6. Select **Save**.

<a name="enable-edge-webview2-for-unified-service-desk-on-client-desktop"></a>

### Enable Edge WebView2 for Unified Service Desk on the client desktop

1. Go to the directory where Unified Service Desk is installed, and double-click to open the **UnifiedServiceDesk.exe.config** file.<br>
Example path: C:\Program Files\Microsoft Dynamics CRM USD\USD

2. In the `<appSettings>` section, add the new key.<br>
`<add key="GlobalBrowserMode" value="EdgeWebView2"/>`

3. Save the file.

<a name="#enable-edge-webview2-for-an-entire-organization"></a>

### Enable Edge WebView2 for an entire organization

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. In the **Global Option** field, choose **Others**. 

5. In the **Name** field, enter **GlobalBrowserMode**.

6. In the **Value** field, enter **EdgeWebView2**.

7. Select **Save**.

## RunScript action is asynchronous in Edge WebView2 Process

The Microsoft Edge browser supports only asynchronous operations, and the RunScript action will be asynchronous.
If your custom code execution is dependent on the return value provided by RunScript action that injects JavaScript into the main frame of the application, your custom code execution might fail.

For example, say your custom code has a RunScript action that injects JavaScript into the main frame of the application followed by an operation or another RunScript action. The RunScript action is invoked and returns a value after the JavaScript injection. If the subsequent operation or another RunScript action is executed based on the return value provided by the executed RunScript action, subsequent operations of your custom code will fail.

### Scenario example

Whenever you open a case, you want to verify whether the case has been open for 10 or more days and then display a message in a dialog. When you perform an action in the dialog, the phone call page is opened for further operations.

To perform this scenario, you must have an action call that executes a RunScript action and returns a value for the next operation. The data on the action call calculates the number of days a case has been open.

Now you create an action call with the action as **ExecuteOnDataAvailable**, and the data field must have the return value of the first action call. That is, the return value will have the form `[[$Return.ActionCallName]]`. This ensures that after the first action is executed and the return is available, this action call will be executed.

Next, you create a subsequent action call to show the number of days a case has been in the open state. The data field will use the return value from the first action call&mdash;that is, `[[$Return.ActionCallName]]`.

You create another action call to open the phone call page and perform the next operation. After seeing the message, you select **OK** on the dialog, and this causes the phone call page to open.

Let's see what configurations you need to create for this scenario.

### Step 1: Create a hosted control

1. Go to **Settings** > **Unified Service Desk** > **Hosted Controls**.

2. Select **New**.

3. Add the following details, and then save the hosted control.

   | Field | Value |
   |--------|---------|
   | Name | Incident |
   | Display Name | `[[incident.title]]` |
   | Unified Service Desk Component Type | Unified Interface Page |
   | Hosting Type | Edge WebView2 Process |
   | Display Group | MainPanel |

### Step 2: Create two action calls

1. Go to  **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **New**.

3. Add the following details, and then save the action call.

   | Field | Value |
   |--------|---------|
   | Name | FindNoOfDaysCaseBeingOpened |
   | Order | 1 |
   | Hosted Control | Incident |
   | Action | RunScript |
   | Data | function findAge(dateString)</br>{</br>if("[[incident.statuscode]]".indexOf("1") > -1){</br>var date1 =new Date(dateString);</br>var date2 =new Date();</br>var timeDiff = Math.abs(date2.getTime() - date1.getTime());</br>var diffDays = Math.ceil(timeDiff / (1000 * 3600 * 24));</br>return diffDays.toString();</br>}</br>return 0;</br>}</br>findAge("[[incident.createdon]]"); |

4. Repeat steps 2 and 3 to create another action call, this time by using the following details.

   | Field | Value |
   |--------|---------|
   | Name | DaysValue|
   | Order | 2 |
   | Hosted Control | CRM Global Manager |
   | Action | ExecuteOnDataAvailable |
   | Data | `[[$Return.FindNoOfDaysCaseBeingOpened]]` |

#### Step 3: Create two action calls, and add them under the DaysValue action call

1. Go to **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **New**.

3. Add the following details, and then save the action call.

   | Field | Value |
   |--------|---------|
   | Name | DisplayMessageForCaseOpen |
   | Hosted Control | CRM Global Manager |
   | Action | DisplayMessage |
   | Data |  text=No of days case is in open state: [[$Return.FindNoOfDaysCaseBeingOpened]]<br>caption=Case is open |

4. Repeat steps 2 and 3 to create another action call, this time by using the following details.

   | Field | Value |
   |--------|---------|
   | Name | OpenPhoneCallPage |
   | Hosted Control | PhoneCall |
   | Action | New_CRM_Page |
   | Data | LogicalName=phonecall<br>description=Long pending case more than 9 days <br> subject=Long pending case <br> |
   | Condition | "[[$Return.FindNoOfDaysCaseBeingOpened]]">9 |

5. From the list of action calls, select the **DaysValue** action call.

6. In the navigation bar next to the **DaysValue** action call, select the closing angle bracket (**>**), and then select **Sub Action Call**.

7. Select **ADD EXISTING ACTION CALL**. In the search field, enter **DisplayMessageForCaseOpen**, and then select the search icon.

8. Select the action call that appears.

9. Repeat steps 7 and 8, this time entering **OpenPhoneCallPage** for the action call.

10. Save the changes.

#### Step 4: Add the action calls to the PageReady event

1. Go to  **Settings** > **Unified Service Desk** > **Events**.

2. Select the **PageReady** event for the **Incident** hosted control from the list of events.

3. On the event page under the **Active Actions** area, select the plus sign (**+**) to add action calls.

4. In the search box that appears, enter **FindNoOfDaysCaseBeingOpened**, select the search icon, and then select the action call. The action call appears under the **Active Actions** area.

5. Repeat step 4, this time entering **DaysValue** in the search box.

6. Save the changes.

## Sign out from sessions when using Edge WebView2 Process

To sign out from sessions when using Edge WebView2 Process, you must configure the sign-out URL by using the **Navigate** action on the hosted control. For example, the sign-out URL for the model-driven app is `url=/main.aspx?signout=1`.

## Enable the confirmation dialog box with Edge WebView2 Process

If you perform an action on an app tab within a Unified Service Desk session and close the session, the **EdgeWebView2ConfirmationDialog** UII option will display a dialog so you can confirm the saving and closing of a session. 

The confirmation dialog is displayed if this UII option has been added or the value is set as **True**. If this option hasn't been added or the value is set as **False**, the confirmation dialog isn't displayed.

**To add the EdgeWebView2ConfirmationDialog UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. In the **Global Option** field, select **Others**.

5. In the **Name** field, enter **EdgeWebView2ConfirmationDialog**. In the **Value** field, enter **True**.

6. Select **Save**.

## Handling the URI protocol in Edge WebView2 Process

When using Edge WebView2 Process, you might want to block the protocol navigation inside the Unified Service Desk client application, or you might want to open the application in a separate window outside of the Unified Service Desk client application. Use window navigation rules to block or open the application outside of the Unified Service Desk client application.

Add the URL in **Window Navigation Rules**, and set the **Action** to **None** to block the navigation or set it to **Show Outside** to show the application outside of the Unified Service Desk client application.

For example, say you've integrated a softphone with Unified Service Desk and are using the Edge WebView2 hosting type to host web applications. When an agent selects the phone number in the contact or account page, you want to initiate the call by using the softphone instead of Skype. You create the window navigation rule and set the **Action** to **None** to block the Skype protocol. You can create specific action calls as subsequent action calls of this window navigation rule to initiate the call by using the softphone.

**To create a window navigation rule**

1. Sign in to the Dynamics 365 instance.

2. Expand **Dynamics 365**.

3. Select **Unified Service Desk Administrator**.

4. Under **Basic Settings**, select **Window Navigation Rules**.

5. On the **Active Window Navigation Rules** page, select **New**.

6. Specify the following values on the **New Window Navigation Rules** page.

   | Tab |  Field | Value |
   |-------------------|------------------------------------------------|--------------------------------------------------|
   | General | Name | Telephone Protocol <br><br> or <br><br> Skype Protocol |
   | General | Url | tel: <br><br> or <br><br> skype: |
   | Result | Route Type | Popup |
   | Result | Action | None or Show Outside |

7. Select **Save**.

Now when an agent selects the number in the contact or account page, based on the window navigation rule, Edge WebView2 Process blocks or opens the application outside of the Unified Service Desk client application.

<a name="#set-focus-on-webpage-when-using-edge-webview2-process"></a>

## Set focus on a webpage when using Edge WebView2 Process

With Edge WebView2 Process, if you want to set the focus on a webpage automatically, you must create an action call with the action as **RunScript** and **Data** as a JavaScript function: `window.top USDEdgeWebView2SetFocus()`. After you create the action call, add it to the **PageReady** event for **Unified Interface Page**, and to the **BrowserDocumentComplete** event for the **CRM Page** hosted control.

<a name="#edit-a-pdf-in-edge-webview2-process"></a>

## Edit a PDF in Edge WebView2 Process

Edge WebView2 Process supports the ability to edit a PDF file inline if the PDF has editable fields.

<a name="#enable-language-support-in-edge-webview2-process"></a>

## Enable language support in Edge WebView2 Process

Edge WebView2 Process supports the ability to switch languages on webpages within Unified Service Desk. To switch languages, you must add the **EdgeWebView2Language** UII option.

**To add the EdgeWebView2Language UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **EdgeWebView2Language**.

7. For the **Value** field, enter the locale code. More information: [Language Codes](/openspecs/office_standards/ms-oe376/6c085406-a698-4e12-9d4d-c3b0ee3dbc4a)

    > [!NOTE]
    > Only the locales available in the path <C:\Program Files\Microsoft Dynamics CRM USD\USD\locales> are supported.

8. Select **Save**.

## Add parameters using Edge WebView2 Process

The Microsoft Edge browser provides many options that can be used on the webpages within Unified Service Desk. The **EdgeWebView2AdditionalBrowserArguments** option helps to add the parameters. 

**To add the EdgeWebView2AdditionalBrowserArguments UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Options**.

4. On the **Active UII Options** page, select **New**.

5. For the **Global Option** field, select **Others**.

6. For the **Name** field, enter **EdgeWebView2AdditionalBrowserArguments**.

7. For the **Value** field, enter a valid Edge WebView2 process parameter.

    The format to add the parameters is:<br> ` --force-ui-direction:rtl;--force-text-direction:rtl;--log-level:3 `.
  
    Note that the parameters are separated by semicolons. More information: [Chromium command-line switches](https://go.microsoft.com/fwlink/p/?linkid=2149189)

8. Select **Save**.

## Debug Edge WebView2 Process

You can debug Edge WebView2 Process in two ways:

- Remotely

- Locally

### Debug Edge WebView2 Process remotely

When you want to access and debug all the Edge WebView2 Process instances running in a desktop remotely, you need to have remote debugging access along with the port number.

Use the **EdgeWebView2RemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `<IP address>:<\port number>` of the remote desktop. You can see all the Edge WebView2 Process instances running in that desktop, and then you can proceed with debugging.

### Debug Edge WebView2 Process locally

When you want to access and debug all the Edge WebView2 Process instances running in a desktop locally, you need to have access along with the port number to connect to.

Use the **EdgeWebView2RemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `localhost:<\port number>` of the local desktop. You can see all the Edge WebView2 Process instances running in that desktop, and then you can proceed with debugging.

Also, within the Unified Service Desk client application, you can debug a Edge WebView2 Process instance by using the keyboard shortcut **F12** to open **Developer Tools**. More information: [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md)

**To add the EdgeWebView2RemoteDebuggingPort UII option**

1. Sign in to the Dynamics 365 instance.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. For the **Global Option** field, select **Others**.

5. For the **Name** field, enter **EdgeWebView2RemoteDebuggingPort**. For the **Value** field, enter the port number (for example, **1030**).

6. Select **Save**.

### See also

[Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  
[Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)  
[Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
