---
title: "Use Chrome Process hosting method for your controls in Unified Service Desk  | MicrosoftDocs"
description: "Learn about the Chrome Process hosting method for your controls in Unified Service Desk."
ms.custom: 
  - dyn365-USD
ms.date: 07/12/2019
ms.service: 
  - dynamics-365-customerservice
ms.topic: "article"
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4.1'
---

# Use Chrome Process to host web application

The Chrome Process browser control hosts your controls in isolated Chrome Process instances and displays them in tabs in the Unified Service Desk client application. The Chrome Process is based on **CefSharp**, an open source framework, which uses the chromium core that powers many modern browsers.  More information: [CefSharp](https://cefsharp.github.io/)

The advantages of using the Chrome process hosting method are as follows:

![Advantages of Chrome Process](media/chrome-process-value-props.PNG "Advantages of Chrome Process")

- Chrome Process is available on different Windows OS versions.
- Chrome Process is highly reliable.
- Easy configurations to host the applications in Unified Service Desk.
- Switch easily from one browser to another for your entire organization.
- Chrome Process pooling feature that reuses the chrome processes and mimics inline navigation provides enhanced performance and memory optimizations.

You can select **Chrome Process** as the hosting method for the **KM Control**, **Unified Interface Page**, **Unified Interface KM Control**, **CRM Page** , **Channel Integration Framework** and **Standard Web Application** type of hosted controls.

## Chrome Process settings

You can set the **Chrome Process** on the hosted controls (existing hosted controls and new hosted controls) to host applications. This allows you to choose the hosted controls that uses **Chrome Process** based on your requirements. More information: [Create a hosted control with hosting type as Chrome](chrome-process.md#create-a-hosted-control-with-hosting-type-as-chrome)

If you want to set the **Chrome Process** to host the applications for an entire organization, then use the **GlobalBrowserMode** Global UII option and specify the value as **Chrome**. More information: [Enable Chrome for Unified Service Desk on client desktop](chrome-process.md#enable-chrome-for-unified-service-desk-on-client-desktop)

If you want to set the **Chrome Process** only for some agents in your organization, then in the **UnifiedServiceDesk.exe.config** file, add the **GlobalBrowserMode** key with the value as **Chrome**. More information: [Enable Chrome for an entire organization](chrome-process.md#enable-chrome-for-an-entire-organization)

### Order of precedence

- Setting the **GlobalBrowserMode** Global UII option value as **Chrome**, takes precedence over the individual hosted control settings. <br><br>For example, some hosted controls have hosting type as **IE Process**, **Chrome Process**, and/or **Internal WPF**. At the organization level, you set **GlobalBrowserMode** Global UII option value as **Chrome**. In this scenario, the Global UII option takes precedence and configuration uses the **Chrome Process** to host the applications. 

- Setting the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes precedence over the individual hosted control settings.<br><br>For example, some hosted controls have hosting type as **IE Process** and/or **Internal WPF**. For a few agents, in their client desktops, you have set **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file. The value set in the **UnifiedServiceDesk.exe.config** file take precedence and configuration uses the **Chrome Process** to host the applications.

Setting the **GlobalBrowser** mode key to **Chrome** in the **UnifiedServiceDesk.exe.config** file for a particular client desktop, takes the precedence over other settings.

## Enable Chrome Process

Enable the **Chrome Process** by doing one of the following ways:

- Create a individual hosted control with hosting type as Chrome Process
- Enable for individual client desktops
- Enable for entire an organization 

> [!NOTE]
> Enable the **Chrome Process** either for individual client desktops or for entire organization.

### Create a hosted control with hosting type as Chrome

When you are creating a new hosted control, you can select **Chrome Process** as the **Hosting Type**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. To create a new hosted control, select **New**.

5. On the **New Hosted Control** page, specify the details and select **Chrome Process** from the **Hosting Type** drop-down.

6. Select **Save** to create the hosted control.

  > [!div class="mx-imageBorder"]
  > ![Select Hosting Type as Chrome Process](media/hosted-control-chrome-process.GIF "Create hosted control with Hosting Type as Chrome Process")

### Enable Chrome for Unified Service Desk on client desktop

1. Go to directory where you have installed Unified Service Desk and double-click to open the **UnifiedServiceDesk.exe.config** file.
Example path: `C:\Program Files\Microsoft Dynamics CRM USD\USD`
  
  > [!Note] 
  > To edit the **UnifiedServiceDesk.exe.config** file, you must have the administrator access permissions.

2. Under the `<appSettings>` section add the new key.<br>
`<add key="GlobalBrowserMode" value="Chrome"/>`

3. Save the file.

  > [!div class="mx-imageBorder"]
  > ![Add Global Browser Mode key with value as chrome](media/chrome-process-app-config-file-setting.GIF "Chrome Process configuration setting")

### Enable Chrome for an entire organization

Add a new Global UII option for your organization named **GlobalBrowserMode**. Specify the value as **Chrome**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. Choose **Others** for the **Global Option** field.

5. Type **GlobalBrowserMode** for the **Name** field.

6. Type **Chrome** for the **Value** field.

7. Select **Save**.

  > [!div class="mx-imageBorder"]
  > ![For the Global Option field enter Global Browser Mode with value as chrome](media/chrome-process-uii-option.GIF "For the Global Option field enter Global Browser Mode with value as chrome")

## Recover a Chrome Process instance

[!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] can help agents to recover the terminated (crashed) webpages hosted in Chrome Process in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].

To learn more, see [Recover a Chrome Process instance](admin/recover-chrome-process-instance.md)

## RunScript action is asynchronous in Chrome Process

The Chrome Process supports only the asynchronous operations, and the RunScript action will be asynchronous.
If your custom code execution is dependent on the return value provided by RunScript action that injects JavaScript into the main frame of the application, then your custom code execution might fail.

For example, Your custom code has a RunScript actions that injects the JavaScript into the main frame of the application followed by an operation or another RunScript action. The RunScript action is invoked and returns a value after the JavaScript injection. If the subsequent operation or another RunScript action executes based on the return value provided by the executed RunScript action, then subsequent operations of your custom code will fail.

### Scenario example 

Whenever you open a case, verify whether the case has been open for 10 or more days, then display a message in a dialog. When you perform an action on the dialog box, the phone call page is opened for further operations.

To perform the above-mentioned scenario, you must have an action call that executes a **RunScript** action and returns a value for the next operation. The data on the action call calculates the number of days a case is open. 

Now, you must create an action call with action as **ExecuteOnDataAvailable**, and the data field must have the return value of the first action call. That is, the return value will have the form `[[$Return.ActionCallName]]`. This ensures that after the first action is executed and the return is available, this action call will be executed.

Next, you must create a sub action call to show the number of days a case is in the open state. The data field will use the return value form the first action call, that is, `[[$Return.ActionCallName]]`.

You must create another sub action call to open the phone call page and perform the next operation. After seeing the message, you select the **OK** button on the dialog, and this causes the phone call page to open.

Let us see what configurations you need to create for the above-mentioned scenario.

### Step 1: Create a hosted control

1. Go to **Settings** > **Unified Service Desk** > **Hosted Controls**.

2. Select **+ New**.

3. Add the following details and save the hosted control.

 | Field | Value |
 |--------|---------|
 | Name | Incident |
 | Display Name | `[[incident.title]]` |
 | Unified Service Desk Component Type | Unified Interface Page |
 | Hosting Type | Chrome Process |
 | Display Group | MainPanel |

### Step 2: Create two action calls

1. Go to  **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **+ New**.

3. Add the following details and save the action call.

 | Field | Value |
 |--------|---------|
 | Name | FindNoOfDaysCaseBeingOpened |
 | Order | 1 |
 | Hosted Control | Incident |
 | Action | RunScript |
 | Data | function findAge(dateString)</br>{</br>if("[[incident.statuscode]]".indexOf("1") > -1){</br>var date1 =new Date(dateString);</br>var date2 =new Date();</br>var timeDiff = Math.abs(date2.getTime() - date1.getTime());</br>var diffDays = Math.ceil(timeDiff / (1000 * 3600 * 24));</br>return diffDays.toString();</br>}</br>return 0;</br>}</br>findAge("[[incident.createdon]]"); |

4. Repeat steps 2 and 3 to create another action call.

| Field | Value |
|--------|---------|
| Name | DaysValue|
| Order | 2 |
| Hosted Control | CRM Global Manager |
| Action | ExecuteOnDataAvailable |
| Data | `[[$Return.FindNoOfDaysCaseBeingOpened]]` |

#### Step 3: Create two action calls, and add them under the DaysValue action call

1. Go to **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **+ New**.

3. Add the following details and save the action call.

| Field | Value |
|--------|---------|
| Name | DisplayMessageForCaseOpen |
| Hosted Control | CRM Global Manager |
| Action | DisplayMessage |
| Data | 	text=No of days case is in open state: [[$Return.FindNoOfDaysCaseBeingOpened]]<br>caption=Case is open |

4. Repeat steps 2 and 3 to create another action call.

| Field | Value |
|--------|---------|
| Name | OpenPhoneCallPage |
| Hosted Control | PhoneCall |
| Action | New_CRM_Page |
| Data | 		LogicalName=phonecall<br>description=Long pending case more than 9 days <br> subject=Long pending case <br> |
| Condition | "[[$Return.FindNoOfDaysCaseBeingOpened]]">9 |

5. From the list of action calls, select the **DaysValue** action call.

6. In the navigation bar, next to the **DaysValue** action call, select the **>** icon, and select **Sub Action Call**.

7. Select the **ADD EXISTING ACTION CALL** option. In the search field, type the action **DisplayMessageForCaseOpen**, and select the search icon.

8. To add the action call, select the action call name that appears.

9. Perform the steps 7 and 8 to add the **OpenPhoneCallPage** action call.

10. Save the changes.

#### Step 4: Add the action calls to the PageReady event

1. Go to  **Settings** > **Unified Service Desk** > **Events**.

2. Select the **PageReady** event for the **Incident** hosted control from the list of events.

3. On the event page, under the **Active Actions** area, select **+** to add action calls.

4. A search box appears, type **FindNoOfDaysCaseBeingOpened** and select the search icon and select the action call. The action call appears under the **Active Actions** area.

5. Repeat step 4 to add the **DaysValue** action.

6. Save the changes.

## Sign out from sessions when using the Chrome Process

To sign out from sessions when using the Chrome process, you must configure the sign-out URL using the **Navigate** action on the hosted control. For example, the sign-out URL is `url=/main.aspx?signout=1`.

## Support for webcam and microphone access with Chrome Process

Agents in your organization require webcam and microphone access according to your business workflow. By default, certain websites may not have access to webcam and microphone. To enable the webcam and microphone support for the Chrome Process, use the **ChromeEnableMediaStream** UII option. Set the UII option to **true** to enable the webcam and microphone support. If you don’t provide any value or set false, the option is disabled.

### Add the ChromeEnableMediaStream UII option

 1. Sign in to the Common Data Service platform.

 2. Go to **Settings** > **Unified Service Desk** > **Options**.

 3. On the Active UII Options page, select **+ New**. 
 
 4. Choose **Others** for the **Global Option** field.

 5. Type **ChromeEnableMediaStream** for the **Name** field.

 6. Type **True** for the **Value** field.

 7. Select save.

## Debug Chrome Process

You can debug the Chrome Process in two ways:

- Remotely

- Locally

### Debug the Chrome Process remotely

When you want to access and debug all the Chrome Process running in a desktop remotely, you need to have remote debugging access along with the port number to connect and debug.

To provide access to the remote desktop to connect and debug, use the **ChromeRemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `<IP address>:<\port number>` of the remote desktop. You can see all the Chrome Process running in that desktop and then you can debug.

### Debug the Chrome Process locally

When you want to access and debug all the Chrome Process running in a desktop locally, you need to have access along with port number to connect and debug.

To provide access to the desktop to connect and debug locally, use the **ChromeRemoteDebuggingPort** UII option and add the port number as the value. After setting this value, from the web browser, go to the `localhost:<\port number>` of the local desktop. You can see all the Chrome Process running in that desktop and then you can debug.

Also, within Unified Service Desk client application, you can debug a Chrome Process by using the keyboard shortcut **F12** to launch the **Developer Tools**. To learn more, see [Manage options in Unified Service Desk](admin/manage-options-unified-service-desk.md).

### Add the ChromeRemoteDebuggingPort UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type **ChromeRemoteDebuggingPort** for the **Name** field, and type the port number value for the **Value** field. For example: `1030`.

6. Select **Save**.

## Enable close confirmation dialog when using Chrome Process

While using Chrome Process to host web applications in Unified Service Desk if you accidentally close any application, even though the application has a close confirmation dialog, the dialog not show for your confirmation and the application closes. To avoid closing the application accidentally, **OnBeforeCloseHandler** UII option is introduced. 

When you enable this UII option and while using Chrome Process to host web applications in Unified Service Desk if you close any application and if the application has a close confirmation dialog, then Chrome Process shows a JavaScript confirmation dialog for you to take an action. The message appears as - **Is it OK to leave/reload the page?**. Select **OK** to close or **Cancel** to stay on the Chrome Process application.

> [!div class=mx-imgBorder]
> ![The JavaScript confirmation dialog shows the message and options to select OK or cancel](media/chrome-process-close-confirmation-dialog.PNG "Close confirmation dialog")

To enable close confirmation dialog, you must add the **OnBeforeCloseHandler** UII option and set the value as **True**. If you leave the value blank or set it to false, the option is disabled.

### Add the OnBeforeCloseHandler UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type **OnBeforeCloseHandler** for the **Name** field and type **True** for the **Value** field. 

6. Select **Save**.

## Set zoom in, zoom out, and zoom reset keyboard shortcuts

By default, the keyboard shortcuts for zoom in, zoom out, and zoom reset are as follows.

| Function | Keyboard shortcut | Example |
|----------|------------|-----------|
| Zoom in |`Ctrl` + `Oemplus`| `Ctrl +` |
| Zoom out |`Ctrl` + `OemMinus`| `Ctrl -`|
| Zoom reset |`Ctrl` + `0`| `Ctrl 0`|

To update additional the keyboard shortcuts, you must add the UII options and provide the character as the value. To learn about the allowed set of character values, see [Keys](https://docs.microsoft.com/dotnet/api/system.windows.forms.keys?view=netframework-4.7.2#fields)

### List of zoom control UII options

| UII option | Description | Example character |
|------------|-------------|-------------------|
| ZoomInControlKey | This option allows you to add a new character to support the zoom in control when using Chrome Process. | `A` |
| ZoomOutControlKey | This option allows you to add a new character to support the zoom out control when using Chrome Process. | `D1` |
| ZoomResetControlKey | This option allows you to add a new character to support the zoom reset control when using Chrome Process. | `NumPad4` |

> [!Important]
> You must take few precautions before providing the value for the character are as follows:
>
> - Ensure that character you update for the UII option doesn't conflict with your existing keyboard shortcuts.
>
> - If you leave the value blank, the default keyboard shortcuts will be disabled.

### Add the Zoom control UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type the name of the UII option for the **Name** field and type value for the **Value** field.<br> See the list of [zoom control UII options](#list-of-zoom-control-uii-options).<br> See the list of [value keys](https://docs.microsoft.com/dotnet/api/system.windows.forms.keys?view=netframework-4.7.2#fields).

6. Select **Save**.

## Set default zoom value for Chrome Process

You can set default zoom value for Chrome Process according to your users' visual preference requirement. Set the value as a fraction, and you can set the default zoom value for:

- Individual users
- For entire organization

### Set default zoom value for Individual users

You can set the default value for individual users using the **UnifiedServiceDesk.exe.config** file.

1. Go to directory where you have installed Unified Service Desk and double-click to open the **UnifiedServiceDesk.exe.config** file.
Example path: `C:\Program Files\Microsoft Dynamics CRM USD\USD`

  > [!Note] 
  > To edit the **UnifiedServiceDesk.exe.config** file, you must have the administrator access permissions.

2. Under the `<appSettings>` section add the new key.<br>
`<add key="DefaultZoomLevel" value="<fraction value>"/>`<br> For example: `<add key="DefaultZoomLevel" value="0.3"/>`

3. Save the file.

### Set default zoom value for entire organization

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type **DefaultZoomLevel** for the **Name** field and enter the value in fraction for the **Value** field. Example of the value: `0.3`, `0.5`, `1.1`, and so on.

6. Select **Save**.

## Allow webpage navigation with unauthorized, expired, and invalid certificates in Chrome Process

If you are navigating to a webpage that has invalid Security Socket Layer (SSL) certificates, unauthorized or expired certificates, then Chrome Process blocks the webpage navigation.

To ignore the certificate errors and allow websites navigation, you must add **AllowWebpageNavigationCertificateError** UII option and set the value as **True**. If you set true, Chrome Process allows webpage navigation for all the websites. 

If you want to choose few websites and don't want to allow all the websites, then provide comma separated values (CSV) of the websites for which you want to ignore the certificate errors. 

For example: `wrong.host.testssl.com,self-signed.testssl.com`

If you leave the value blank or set the value as **False**, then Chrome Process blocks the webpage navigation for all the websites with certificates errors.

### Add the AllowWebpageNavigationCertificateError UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type **AllowWebpageNavigationCertificateError** for the **Name** field, and type the value as **True** or comma seperated values (CSV) of the websites you want allow the navigation. For example: `wrong.host.testssl.com,self-signed.testssl.com`. 

6. Select **Save**.

## Accessibility support with Chrome Process

When you use Chrome Process to host web application in Unified Service Desk, to enable accessibility support for the webpages, the **ChromeAccessibilityRenderer** is introduced. By default, the accessibility support for chrome process is disabled. Add the UII option and set the value as **True** to enable and ensure that screen reader applications read the webpage.

After adding the UII option, if you set to false or leave the value empty, the UII option is disabled.

### Add the AllowWebpageNavigationCertificateError UII option

1. Sign in to the Common Data Service platform.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the Active UII Options page, select **+ New**. 

4. Choose **Others** for the **Global Option** field.

5. Type **ChromeAccessibilityRenderer** for the **Name** field, and type the value as **True**. 

6. Select **Save**.

## Set focus on webpage when using Chrome Process

When using Chrome Process to host web applications in Unified Service Desk, if you want to set the focus on the webpage automatically, then you must create an action call with action as **RunScript** and **Data** with a JavaScript function - `window.top.USDChromeSetFocus()`. After you create the action call, add it to the **PageReady** event in case of **Unified Interface Page** and the **BrowserDocumentComplete** event in case of the **CRM Page** hosted control.

## Handle URI protocol in Chrome Process

When using Chrome Process, you might want to block the protocol navigation inside Unified Service Desk client application or want to open the application in a separate window outside of Unified Service Desk client application. Use the Window Navigation Rules to block or open the application outside of Unified Service Desk client application. 

Add the URL in the Window Navigation Rules and set the **Action** to **None** to block the navigation and set **Show Outside** to show the application outside of Unified Service Desk client application.

For example, you've integrated a softphone with Unified Service Desk and using the Chrome Process hosting type to host web applications. Now, when an agent selects the phone number in the contact or account page, you want to initiate a call using the softphone instead of Skype. Now, create the window navigation rule and set the **Action** to **None** to block skype protocol. Now, you can create specific action calls as sub-action calls of this window navigation rule to initiate the call using softphone.

To create a Window Navigation Rule, follow the steps:

1. Sign to the Common Data Service platform.

2. Select down arrow next to Dynamics 365.

3. Select **Unified Service Desk Administrator**.

4. Select **Window Navigation Rules** under **Basic Settings**.

5. Select **+ New** in the **Active Window Navigation Rules** page.

6. Specify the following values on the **New Window Navigation Rules** page.

   | Tab |  Field | Value |
   |-------------------|------------------------------------------------|--------------------------------------------------|
   | General | Name | Telephone Protocol <br><br> or <br><br> Skype Protocol |
   | General | Url | tel: <br><br> or <br><br> skype: |
   | Result | Route Type | Popup |
   | Result | Action | None or Show Outside |

7. Select **Save**.

Now, when an agent selects the number in the contact or account page, based on the window navigation rule, Chrome Process blocks or opens the application outside of Unified Service Desk client application.

## Generate Chrome Process crash report

You must generate the reports when you want to investigate the Chrome Process crash in Unified Service Desk. To generate the report, you must add the **ChromeEnableLogging** UII option and set the value as **True**.  The files are generated in the following location:

`C:\Users\agent1\AppData\Roaming\Microsoft\USD\CEF\cef_debug.log`

### Add the ChromeEnableLogging UII option

1. Sign in to the Common Data Service platform.

2. [!INCLUDE[proc_settings_usd](../includes/proc-settings-usd.md)]

3. Choose **Options**.  

4. Select **New** on the **Active UII Options** page.

5. Choose **Others** for the **Global Option** field.

6. Type **ChromeEnableLogging** for the **Name** field.

7. Set **True** for the **Value** field.

8. Select **Save**.


## Use window.IsUSD property to invoke Unified Service Desk event

With Chrome Process, if you use the `window.IsUSD` property in your JavaScript code, you must use it on the predefined events like **pageReady** and **BrowserDocumentComplete** to determine whether the JavaScript code is running under Unified Service Desk or not.

When you use the property on the Unified Service Desk predefined events, the property returns true. Otherwise, it returns false.

## Download attachments in Chrome Process

When you use Chrome Process to host web applications in Unified Service Desk and select a file attachment, by design, Chrome Process prompts you to save the file to a local folder. After saving the file, you can open to view it.


## Limitations

To learn about the limitations of the Chrome Process, see [Chrome Process limitations](release-notes.md)

## See also

[Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  

[Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   

[Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)

[Recover chrome process instance](admin/recover-chrome-process-instance.md)
