---
title: "Templates | Microsoft Docs"
description: "Learn about the system requirements of Channel Integration Framework (CIF) for Microsoft Dynamics 365 and how to get started using it."
keywords: ""
ms.date: 09/30/2019
ms.service:
  - dynamics-365-cross-app
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
ms.assetid: 7A99074E-9C3E-4DF0-98B4-AB7546C892C1
author: susikka
ms.author: susikka
manager: shujoshi
---

# Templates

When you (agents) get an incoming conversation request, the Channel Integration Framework version 2.0 allows channel providers to search and open records on an incoming call. However, your organization might have different requirements and want to use different custom entities and correlate to a conversation.

Also, the **Omnichannel for Customer Service app** allows you to open third-party web applications in the application tabs. Your organization may have different line-of-business applications, and while starting a session, you want to load the line-of-business applications for a specific conversation type.

For example: When an agent gets an incoming chat conversation notification, and he/she accepts the notification, a session starts. For every chat session, when the omnichannel application identifies the customer, you want to open a contact record, related case page, SharePoint site, and the line-of-business application.

To choose the applications you want to open for every session, according to your organization requirements, session templates are introduced.

> [!WARNING]
> It is recommended that you don’t edit the out-of-the-box-sample templates present in the package as it affects the functionality.

## Session templates

Session template in Channel Integration Framework app is a combination of attributes and application tab information that are reusable.

As an agent, when you accept a chat or SMS incoming conversation request, a session is started. The **Customer Summary** application that is defined as **Anchor Tab** is opened in the application tab panel, and it is not closable. Simultaneously, the communication panel is expanded for you to exchange messages with the customer.

Session templates are used to define the session experience such as,

-   which application must be opened as an anchor tab in the application tab panel;

-   what are the additional application tabs that must be opened when a session is started;

-   what must be the default mode of the communication panel when a session is started.

In your environment, as an administrator, you can create multiple session templates.

The out-of-the-box- session templates are as follows:

- **Chat for Dynamics 365:** This session template is used for any incoming conversation from the Chat channel.

- **SMS for Dynamics 365:** This session template is used for any incoming conversation from the SMS channel.

- **Entity Routing:** This session template is used for an entity record like case request.

A session template is the place where, as an administrator, you must define the anchor tab and additional application tabs that must open when a session starts.

### Create a session template

To create a session, follow these steps:

1.  Sign in to the Channel Integration Framework app.

2.  Select **Sessions** under **Templates** in the sitemap.

3.  Select **+ New** in the **Active Session Templates** page.

4.  Specify the following in the **New Session Templates** page.

| **Tab** | **Name**                 | **Value description**                                                                                                                                                   | **Example**                                                                |
|---------|--------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------|
| General | Name                     | Specify the name of the session. This name wouldn't be visible for the agents at the run-time.                                                                          | Chat session                                                               |
| General | Title                    | Provide the title of the session that you want the agents to see at the run-time.                                                                                       | {customerName}                                                             |
| General | Communication panel mode | Select the default mode of the panel when a session is started. Choose one of the following:                                                                            
                                                                                                                                                                            
   - **Docked:** The panel will be in expanded mode.                                                                                                                      
                                                                                                                                                                            
   - **Minimized:** The panel will be in minimized mode.                                                                                                                  
                                                                                                                                                                            
   - **Hidden:** The panel will be hidden and will not be shown.                                                                                                          
                                                                                                                                                                            
 **Note:** For an entity routing session, that is, for a case session, the communication panel mode is hidden.                                                            | Docked                                                                     |
| General | Description              | Provide a description for your reference.                                                                                                                               | The session template is used for a conversation request from Chat channel. |
| General | Anchor tab               | Select an application from the list. By default, the application is opened by default when the session is started, and this application is not closable.                
                                                                                                                                                                            
 **Note:** To select an application tab apart from the out-of-the-box application tabs, you must first create the application tab, and then create the session template.  | Customer summary                                                           |

1.  Select **Save** to save the session template. After you save, the **Additional tabs** option appears in the page.

2.  Select **Add Existing Application Tab Template** to add additional application tabs that you want to be opened when a session is started. Agents can't close this application tabs. The **Lookup Records** pane appears.

3.  Select the application tab names in the search box and select the search icon. A list of record appears. Select the application tab and select **Add**.

4.  Select **Save** to save the changes.

## Application tab templates

Application tab template in the Channel Integration Framework app provides the type of applications you want to open when a session is started. Each application type has a predefined set of parameters associated with it.

The horizontal bar below the Dynamics 365 navigation bar is called the Application tab panel. Every customer session has at least one application tab that is not closable; it is called an anchor tab. That is when a session is started, by default, an application is opened in the application tab panel. Also, there may be few other applications that are opened by default.

![Channel Integration Framework for Dynamics 365 version 2 0   Private Preview  2  image14](media/Channel-Integration-Framework-for-Dynamics-365-version-2.0---Private-Preview-(2)-image14.png)  

With the application tab template, you can define the applications and associate the application as an anchor tab or additional applications in a session template.

For example, you can create the Customer summary application type and associate it with a Chat or SMS session. Now, when an agent accepts the notification from the Chat or SMS channel, a session is started and by default the Customer summary page loads for the agent.

In your environment, as an administrator, you can create multiple application tab templates.

### Create an application tab template

1.  Sign in to the Channel Integration Framework app.

2.  Select **Application Tabs** under **Templates** in the sitemap.

3.  Select **+ New** in the **Active Application Tabs** page.

4.  Specify the following in the **New Application Tabs** page.

<table>
<thead>
<tr class="header">
<th><strong>Tab</strong></th>
<th><strong>Name</strong></th>
<th><strong>Value description</strong></th>
<th><strong>Example</strong></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>General</td>
<td>Name</td>
<td>Specify the name of the application tab. This name wouldn't be visible for the agents at the run-time.</td>
<td>KB Search Page</td>
</tr>
<tr class="even">
<td>General</td>
<td>Application title</td>
<td>Provide a title to the application that you want the agents to see at the run-time.</td>
<td>KB Search Page</td>
</tr>
<tr class="odd">
<td>General</td>
<td>Application type</td>
<td><p>Select a application type from the list. Choose one of the following: </p>
<ul>
<li><blockquote>
<p>Custom control</p>
</blockquote></li>
<li><blockquote>
<p>Dashboard</p>
</blockquote></li>
<li><blockquote>
<p>Entity view</p>
</blockquote></li>
<li><blockquote>
<p>Entity record</p>
</blockquote></li>
<li><blockquote>
<p>Entity search</p>
</blockquote></li>
<li><blockquote>
<p>Web resource</p>
</blockquote></li>
<li><blockquote>
<p>Website Url</p>
</blockquote></li>
</ul></td>
<td>Web resource</td>
</tr>
<tr class="even">
<td>General</td>
<td>Description</td>
<td>Provide a description for your reference.</td>
<td>The application type is used to display KB Search Page.</td>
</tr>
<tr class="odd">
<td>General</td>
<td>Value</td>
<td>Specify a value against the parameter.</td>
<td>msdyn_kbsearchpagehost.html <br />
<br />
Update the value against the <strong>webresourceName</strong> parameter</td>
</tr>
</tbody>
</table>

1.  Select **Save** to save the application tab template. After you save, the parameters for the application type you selected is appears in the **Parameters** section.

2.  Select the **Value** field of a parameter to edit and provide the value. To learn about the custom parameter values, see the [Client API Reference](https://docs.microsoft.com/en-us/powerapps/developer/model-driven-apps/clientapi/reference).  

3.  Select **Save** to save the changes.

## Notification templates

When agents get a notification, the notification displays certain information like from which customer the conversation request is coming, wait time, some button like accept and reject. Each organization has varied business requirements and want to show relevant information in the notification to agents.

The notification templates are introduced to show relevant information to agents. A notification template in Channel Integration Framework app is a combination of notification related information that is reusable. The template is used to configure what information is displayed to the agents and supervisors for an incoming conversation, escalation, transfer, consult, and so on.

As an administrator, system integrator, or partner, you can use the templates or create new ones to show information that matter most to your business.

You must associate the notification templates to a session template.

### Create a notification template

1.  Sign in to the Channel Integration Framework app.

2.  Select **Notifications** under **Templates** in the sitemap.

3.  Select **+ New** in the **Active Notifications** page.

4.  Specify the following in the **New Application Tabs** page.

| **Tab** | **Name**          | **Value description**                                                                                                                                                  | **Example**                                                                           |
|---------|-------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------|
| General | Name              | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time.                                                                   | Authenticated chat notification                                                       |
| General | Title             | Provide a title to the notification that you want the agents to see at the run-time.                                                                                   | Incoming chat conversation                                                            |
| General | Icon              | Select web resource path to add an icon.                                                                                                                               | /webresources/msdyn\_chat\_icon\_zfp.svg                                              
                                                                                           
 **Note:** This is the default value. You can change the icon as your requirement.      |
| General | Timeout (seconds) | Provide a duration in seconds. After this duration, the notification disappears.                                                                                       | 120                                                                                   
                                                                                           
 **Note:** This is the default value. You can change the duration as your requirement.  |
| General | Accept Button     | Specify a text for the accept button. This text appears for the agents to accept a conversation request.                                                               | Accept                                                                                
                                                                                           
 **Note:** This is the default value. You can change the text as your requirement.      |
| General | Reject Button     | Set the toggle to yes if you want to show the reject button to agents.                                                                                                 
                                                                                                                                                                           
   After you set the toggle to Yes, the button text box appears. Specify a text for the accept button. This text appears for the agents to accept a conversation request.  | Reject                                                                                
                                                                                           
 **Note:** This is the default value. You can change the text as your requirement.      |

1.  Select **Save** to save the notification template. After you save, the **Notification Fields** section appears in the page.

2.  Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

3.  Select the search icon in the **Look for Records** box. If there are no records, you see a message – **No records found. Create a new record**.

4.  Select **+ New** to create a new notification field. A confirm dialog appears stating if you want to leave the page. Select **OK**.

5.  Specify the following in the **New Notification Field** page.

| **Tab** | **Name**     | **Value description**                                                                                                                                            | **Example**                         |
|---------|--------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------|
| General | Name         | Specify the name for the notification. This name wouldn't be visible for the agents at the run-time.                                                             | Name of the customer                |
| General | Field header | Provide a field header. This appears in the notification that agents to see at the run-time.                                                                     | Name                                |
| General | Value        | Provide a value that appears against **Field header** in the notification.                                                                                       | {customerName}                      
                                         
 **Note:** This is an example value.  |
| General | Priority     | Provide a number to assign the priority, which is the order of appearance on the notification. If you give the priority as 4, the field appears as 4th from top. 
                                                                                                                                                                     
   A maximum of four Field headers are shown on a notification.                                                                                                      | 1                                   |

1.  Select the back arrow on the browser to go the notification template you created. Alternatively, you select **Notifications** in the sitemap and then select the template you created.

2.  Select **Add Existing Notification Field** in the **Notification Fields** section. The **Lookup Records** pane appears.

3.  Select the name of the notification field you created, and then select **Add**. For example, **Name of the customer**.

4.  Repeat steps 6 through 12 to add more notification fields.

5.  Select **Save** to save the notification template changes.

### Editing a notification field

As an administrator, you can edit the value of notification field header in the grid.

1.  Sign in to the Channel Integration Framework app.

2.  Select **Notifications** under **Templates** in the sitemap.

3.  Select the notification you want to edit in the **Active Notifications** page.

4.  Select a notification field you want to edit. Select the record to edit it.

5.  Select the save icon to save the changes.