---
title: "Edge process hosting method for your controls in Unified Service Desk for Dynamics 365 Customer Engagement| MicrosoftDocs"
description: "Learn about the edge process hosting methods for your controls in Unified Service Desk."
ms.custom: 
  - dyn365-USD
ms.date: 12/01/2018
ms.service: dynamics-365-customerservice
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: D9E7AED8-1D3A-4E62-BD15-7C5CF153EB4E
author: kabala123
ms.author: kabala
manager: shujoshi
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
monikerRange: '>= dynamics-usd-4'
---

# Edge Process

The Edge Process browser control hosts your controls in individual Edge process instances and displays them in tabs in the Unified Service Desk client application. It facilitates predictable and secure page rendering by making sure that if your web application works in Edge, it will work in Unified Service Desk. You can select Edge Process as the hosting method for the **CRM Dialog**, **CRM Page**, **KM Control**, **Unified Interface Page**, **Unified Interface KM Control** and **Standard Web Application** type of hosted controls.

The advantages of Edge process are as follows:

- Web pages, including Dynamics 365 pages, renders faster in Edge.
- The Edge is a modern browser with better process and memory management.
- Edge is the default browser for Windows 10 operating system.
- Easy configurations to host the applications in Unified Service Desk.
- Improved reliability and supportability for browser-specific issues

> [!NOTE]
> To use Edge process, you must have the latest Windows 10 operating system (Windows 10 October 2018 release).

Setting the **GlobalBrowser** mode key to **Edge** in the application configuration file (UnifiedServiceDesk.exe.config) for a particular client desktop takes the precedence over other settings. That is, even though at the organization level or if the hosted controls have different hosting type such as **IE Process** and/or **Internal WPF**, the settings from the application configuration file (UnifiedServiceDesk.exe.config) takes the precedence and uses the edge process to host the applications.

## Enable Edge process

Enable the edge process using any of the following ways:

- Enable for individual client desktops
- Enable for entire organization

> [!NOTE]
> Enable the edge process either for individual client desktops or for entire organization.

### Enable Edge for Unified Service Desk on client desktop

1. Go to directory where you have installed Unified Service Desk and double-click to open the UnifiedServiceDesk.exe.config file.
Example path: `C:\Program Files\Microsoft Dynamics CRM USD\USD`
2. Under the `<appSettings>` section add the new key.<br>
`<add key="GlobalBrowserMode" value="Edge"/>`

  > [!div class="mx-imageBorder"]
  > ![Edge process configuration setting key](media/edge-process-app-config-file-setting.PNG "Edge process configuration setting key")

3. Save the file.

### Enable Edge for entire organization

Add a new Global UI option for your organization named **GlobalBrowserMode** with value as **Edge**.

1. Sing-in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk** > **Options**.

3. On the **Active UII Options** page, select **New**.

4. Choose **Others** for the **Global Option** field.

5. Type **GlobalBrowserMode** for the Name field.

6. Type **Edge** for the **Value** field.

7. Select **Save**.

## Create hosted control with hosting type as Edge

When you are creating new hosted control, you can select **Edge Process** as the **Hosting Type**.

1. Sign in to Dynamics 365.

2. Go to **Settings** > **Unified Service Desk**.

3. Select **Hosted Controls**. The page displays available hosted controls.

4. To create a new hosted control, select **New**.

5. In the **New Hosted Control** page, specify the details and select **Edge process** from the **Hosting Type** drop-down.

6. Select **Save** to create the hosted control.

## Debug Edge process using Microsoft edge DevTools Preview

With Edge process, you can use the **Microsoft Edge DevTools Preview** tool as a JavaScript debugger. The Edge DevTools help you debug the webpage locally or remotely.

In the panel, you can all the active Edge process. select the desired webpage to from the active list to open a new instance.

More information: [Microsoft Edge DevTools Preview](https://docs.microsoft.com/en-us/microsoft-edge/devtools-guide)

## RunScript action is asynchronous in Edge process

The Edge browser support only the asynchronous operations, and the RunScript action will be asynchronous.
If your custom code execution is dependent on the return value provided by RunScript action that injects JavaScript into the main frame of the application, then your custom code execution may fail.

For example, Your custom code has a RunScript actions that injects the JavaScript into the main frame of the application followed by an operation or another RunScript action. The RunScript action is invoked and returns a value after the JavaScript injection. If the subsequent operation or another RunScript action executes based on the return value provided by the executed RunScript action, then subsequent operations of your custom code will fail.

### Scenario example 

Whenever you open a case, you want to verify if the case is open for 10 or more days, then display a message in a dialog and when you perform an action on the dialog, phone call page is opened for further operations.

To perform the above-mentioned scenario, you must have an action call that executes a **RunScript** action and returns a value for the next operation. The data on the action call calculates the number of days a case is open. 

Now, you must create an action call with the action, **ExecuteOnDataAvailable**, and the data field must have the return value of the first action call. That is, the return value will in the form `[[$Return.ActionCallName]]`. This ensures after the first action is executed and the return is available, this action call will be executed.

Next, you must create an sub action call to show the number of days a case is in open state. The data field will use the return value form the first action call. That is, `[[$Return.ActionCallName]]`.

You must create another sub action call to open the phone call page and perform the next operation. After seeing the message and you select the OK button on the dialog, and this causes the phone call page to open.

Let us see what configurations you need to do create for the above-mentioned scenario.

### Step 1: Create a hosted control

1. Go to the **Settings** > **Unified Service Desk** > **Hosted Controls**.

2. Select **+ New**.

3. Add the following details and save the hosted control.

| Field | Value |
|--------|---------|
| Name | Incident |
| Display Name | `[[incident.title]]` |
| Unified Service Desk Component Type | Unified Interface Page |
| Hosting Type | Edge process |
| Display Group | MainPanel |

### Step 2: Create two action calls

1. Go to the **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **+ New**.

3. Add the following details and save the action call.

| Field | Value |
|--------|---------|
| Name | FindNoOfDaysCaseBeingOpened |
| Order | 1 |
| Hosted Control | Incident |
| Action | RunScript |
| Data | function findAge(dateString)</br>{</br>if("[[incident.statuscode]]".indexOf("1") > -1){</br>var date1 =new Date(dateString);</br>var date2 =new Date();</br>var timeDiff = Math.abs(date2.getTime() - date1.getTime());</br>var diffDays = Math.ceil(timeDiff / (1000 * 3600 * 24));</br>return diffDays.toString();</br>}</br>return 0;</br>}</br>findAge("[[incident.createdon]]"); |

4. Repeat the step 3 and 4 to create another action call.

| Field | Value |
|--------|---------|
| Name | DaysValue|
| Order | 2 |
| Hosted Control | CRM Global Manager |
| Action | ExecuteOnDataAvailable |
| Data | `[[$Return.FindNoOfDaysCaseBeingOpened]]` |

#### Step 3: Create two action calls and add them under the DaysValue action call

1. Go to the **Settings** > **Unified Service Desk** > **Action Calls**.

2. Select **+ New**.

3. Add the following details and save the action call.

| Field | Value |
|--------|---------|
| Name | DisplayMessageForCaseOpen |
| Hosted Control | CRM Global Manager |
| Action | DisplayMessage |
| Data | 	text=No of days case is in open state: [[$Return.FindNoOfDaysCaseBeingOpened]]<br>
caption=Case is open |

4. Repeat the step 3 and 4 to create another action call.

| Field | Value |
|--------|---------|
| Name | OpenPhoneCallPage |
| Hosted Control | PhoneCall |
| Action | New_CRM_Page |
| Data | 		LogicalName=phonecall<br>description=Long pending case more than 9 days <br> subject=Long pending case <br> |
| Condition | "[[$Return.FindNoOfDaysCaseBeingOpened]]">9 |

5. From the list of action calls, select the **DaysValue** action call.

6. In the navigation bar, next to the **DaysValue** action call, select the *>* icon, and select **Sub Action Call**.

7. Select the **ADD EXISTING ACTION CALL** option, and in the search field, type the action **DisplayMessageForCaseOpen**, and select the search icon.

8. To add the action call, select the action call name that appears.

9. Perform the steps 7 and 8 to add the **OpenPhoneCallPage** action call.

10. Save the changes.

#### Step 4: Add the action calls to the PageReady event

1. Go to the Settings > Unified Service Desk > Events.

2. Select the **PageReady** event for the **Incident** hosted control from the list of events.

3. On the event page, under the **Active Actions** area, click **+** to add action calls.

4. A search box appears, type **FindNoOfDaysCaseBeingOpened** and select the search icon and select the action call. The action call appears under the **Active Actions** area.

5. Repeat the step 4 to add the **DaysValue** action.

6. Save the changes.

## Limitations of Edge process

### CloseAndPrompt action

The Edge process does not support the **CloseAndPrompt** action for Dynamics 365 for Customer Engagement Web Client. When you make changes in a webpage or a form on Web Client, the process does not perform a dirty data check by prompting a dialog. Instead, when you close the webpage or the form, Unified Service Desk closes the webpage or the form.

### Alert dialog support with WebView control

The Edge process doesn't support the native JavaScript alert dialog in the WebView. When you use Edge WebView control, the alert dialog shows the information. However, the alert does not stop the JavaScript execution. That is, even though you do not perform an action on the alert dialog, the JavaScript execution continues.

### Confirm dialog support

The Edge process doesn't support the confirm dialog in the WebView. If your custom code uses the confirm dialog, the Edge process in the WebView does not support the execution and your code may fail.

## See also  
 [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md)  

 [Hosted control types and action/event reference](../unified-service-desk/hosted-control-types-action-event-reference.md)   

 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)