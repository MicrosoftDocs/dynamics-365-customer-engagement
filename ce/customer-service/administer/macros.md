---
title: "Macros in the Customer Service workspace app | MicrosoftDocs"
description: "This topic provides information about the different macros that can be made available to agents and how to configure them."
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 06/16/2023
ms.topic: how-to
ms.custom: bap-template
---

# Automate tasks with macros

In the customer service industry, agents have to click often to perform simple tasks, such as open a form, fill, and save it, and many repetitive and monotonous actions, such as greeting and verifying a customer, sending acknowledgment mail, and taking notes. These clicks and repetitive tasks can lead to human errors when agents copy and paste the data across different operations.

Macros are a set of sequential actions that are performed by a user. They enable users to perform daily operations efficiently in a fast and process-compliant manner. You can reuse macros with different sessions based on the context parameters that are specific to the session.


## Prerequisites

- Make sure that you have the **Productivity tools administrator**  or **System Administrator** security role to design macros.

- Make sure that agents and supervisors are assigned the **Productivity tools user** or **Customer Service representative** security role to execute macros.

More information: [Assign roles and enable users](../implement/add-users-assign-roles.md)

## Create a Macro

Perform the following steps to create a macro in Customer Service admin center:
1. Go to **Productivity** in **Agent experience**. 
2.  Select **Manage** for **Macros**. 
3. Select **New**. In the **Macros** page, specify a name and description for the macro. The first step for the macro is always **Start macro execution**.

### Trigger macros

A macro can be triggered as follows:

- Agents can run [macros](../use/oc-agent-scripts.md#macro) from the **Productivity** pane in the Customer Service workspace app.
- Through an [API](../develop/reference/methods/runMacro.md)

For more information on agent experience profiles, session templates, agent script, agent script steps and macros, download the Customer Service workspace in a day training.


## Predefined automation actions

In Customer Service, macros provide three connectors:

- [Productivity automation](#productivity-automation): Provides actions to perform model-driven app operations. Productivity automation macros allow you to automate tasks such as opening and updating records, opening views, resolving cases, searching the knowledge base, record cloning, setting focus to another agent script, opening email templates, auto filling form fields, setting and retrieving variables and values in the session context.

- [Session connector](#session-connector): Provides actions to perform session-related operations. Session connector macros enables you to add actions such as getting the ID of a tab, refreshing a tab, passing the tab id, setting focus to a tab based on the tab id, opening a tab template, and refreshing session context.

- [Omnichannel connector](#omnichannel-connector): Provides actions to perform Omnichannel for Customer Service&ndash;related operations.  Omnichannel connector macros allow you to link and unlink records to conversations.

- Flow connector: Allows you to execute a Power Automate flow.

## Pass session context variables to macros

In a macro, you can pass dynamic values such as customer name or customer id as parameters during the macro execution. The information is stored in the session context as a key value pair. A session context variable is also known as a [slug](automation-dictionary-keys.md#slugs). 
 

### Records 

When you open a case as a session, the case is the "anchor tab" or the first tab of the session. The session context is populated with the attributes and values from the case record and is stored in the browser memory. For example, if a case is open as the anchor tab, the session context variables are populated as follows:  

`${anchor.incidentid} : 6194b723-7e5f-eb11-a812-000d3a1a658a `
`${anchor.ticketnumber} : CAS-47732-V4V6K6 `
`${anchor.title} : A Mineral Build Up in Water Supply` 
`${anchor.createdon} : 2022-12-14T23:03:24Z `
`${anchor.prioritycode} : 2` 
`${anchor.prioritycode@OData.Community.Display.V1.FormattedValue} : Normal` 
`${anchor._customerid_value} : f5973462-768e-eb11-b1ac-000d3ae92b46 `
`${anchor._customerid_value@Microsoft.Dynamics.CRM.lookuplogicalname} : contact `
`${anchor._customerid_value@OData.Community.Display.V1.FormattedValue} : Claudia Mazzanti `


> [!NOTE]
> The session context is populated with values from the anchor tab only.

You can also retrieve a value from a related record using an oData query. For example, you can use the following oData query to retrieve the email address from the customer record on a case: 
 
`${$odata.contact.emailaddress1.?$filter=contactid eq '{anchor._customerid_value}'} `

### Conversations 

When an agent accepts an incoming call or chat, the session context is populated with the conversation attributes from the channel provider and stored in the browser cache. For example, the session context variables are populated as follows for an incoming chat conversation:  

`${Email} : claudiamazzanti@crmdemo.dynamics.com `

`${LiveWorkItemId} : 57e4323e-a93f-4c30-b8e8-b075ab5d71cc `
`${customerEntityName} : contact `
`${customerName} : Claudia Mazzanti `
`${customerRecordId} : f5973462-768e-eb11-b1ac-000d3ae92b46 `
`${queueId} : 6b189e87-e09b-eb11-b1ac-000d3af4e3f9 `

`${visitorLanguage} : en-us `

 

You can also retrieve a value from a related record using oData query. For example, you can retrieve the email address from the customer record on a case as follows:

`${$odata.contact.emailaddress1.?$filter=contactid eq '{customerRecordId}'} `


### Additional tabs 

When an agent opens an entity record, the session context is populated with attributes from the record in the anchor tab. Records open in the additional tabs of the same session aren't used in the session context. However, you can access the name of the entity and the entity record id as fillows: 
 
`${Session.CurrentTab.entityId} : 0e8642d7-c2ae-ea11-a812-000d3a1b14a2 `
`${Session.CurrentTab.entityName} : account `
With the entity id, you can retrieve other values in the record through the following oData query: 
 
`${$odata.account.name.?$filter=accountid eq '{Session.CurrentTab.entityId}'}`



### Session connector

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to a session in Customer Service workspace.

   :::image type="content" source="../media/macro-session-connector.png" alt-text="Macro actions for session connector.":::

#### Get the current tab

This action gets the details of the current tab in Omnichannel for Customer Service. The action retrieves the Tab ID that could be used in the **Refresh tab** and **Focus tab** actions.

#### Open application tab

This action opens the specified application in a new tab with the attributes that you define. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Page type | Specify  the application type to be opened. More information: [Page types](application-tab-templates.md#page-types) <br> This is a mandatory field.  |
   | Application Template ID  | Specify the ID of the application template. <br> This is a mandatory field. |
   | Attribute Name | Specify the attribute logical name you want to update.| |
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. | |

#### Refresh the session context

This action refreshes the session context in Customer Service workspace for entity sessions. For example, if you launch an entity session for a case record, the session context variables will be defined when the session starts. However, if you update the case title, the session context will not be updated. Therefore, macros will use the cached information. You can add the **Refresh the session context** step after starting the macro run to use the latest information.

#### Refresh the tab

This action refreshes a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Tab ID | Specify the ID of the tab that you want to refresh. <br> This is a mandatory field.| 

#### Focus on the tab

This action focuses on a tab in the Customer Service workspace session. This action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Tab ID | Specify the identifier of the tab that you want to give focus to. <br> This is a mandatory field.|

### Omnichannel connector

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service.

> [!NOTE]
> Macro actions for the Omnichannel connector is available if Customer Service workspace in Omnichannel for Customer Service is installed.

   :::image type="content" source="../media/macro-omnichannel-connector.png" alt-text="Macro actions Omnichannel connector.":::

#### Send knowledge base article link in chat

This action sends a knowledge base article link to the conversation chat window. It must be used with the **Search knowledge base for the populated phrase** action. Make sure that your admin has switched the **Use an external portal** toggle to **Yes**. More information: [Set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management)

The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity record ID  | Specify the ID of the entity record. <br> This is a mandatory field. |

#### Link record to the conversation

This action links a record to the conversation when the customer is communicating with the agent in the Omnichannel for Customer Service session. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to link. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record ID of the entity that you want to link. <br>This is a mandatory field.| |
   | Entity primary Name | Specify the primary name of the entity that you want to link. <br>This is a mandatory field.| |

#### Unlink record from the conversation

This action unlinks a record from the conversation when the customer is communicating with the agent in the Omnichannel for Customer Service session. This action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity Logical Name |  Specify the logical name of the entity that you want to unlink. <br> This is a mandatory field. | incident |
   | Entity record id| Specify the entity record ID of the entity that you want to unlink. <br>This is a mandatory field.| |
   | Entity primary Name | Specify the primary name of the entity that you want to unlink. <br>This is a mandatory field.| |

### Flow connector

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to Omnichannel for Customer Service and Customer Service workspace.

   :::image type="content" source="../media/macro-flow-connector.png" alt-text="Macro actions for flow connector.":::

#### Run Flow

This action triggers Power Automate flows using macros in agent scripts. This action contains the following fields.

| Field                | Description                             | Parameter  |
|----------------------|-----------------------------------------|------------|
| Entity logical name | Specify the logical name of the entity that you want to link. This is a mandatory field. Any Microsoft Dataverse entity, such as Account, can be used based on business needs. | account   |
| Entity record id     | Specify the entity record ID of the entity that you want to link. This is a mandatory field. Ids or slugs, such as {customerRecordId}, can be used. While this field is labeled as entity record id, any value to be processed can be passed. While the field is required, values do not have to be functional unless required for the flow logic. | {customerRecordId}   |
| Select flow         | Specify or select the Power Automate flow to be run by this action. Requires instant cloud flows with *When a record is selected* flow triggers. Existing flows with proper permissions will be detected and displayed in the drop-down list. |    |

#### Power Automate flow permissions

Referenced flows require valid connection and run permissions for the Omnichannel for Customer Service and Customer Service workspace tenant and agents that run the flow from within agent scripts.

   :::image type="content" source="../media/flow-permissions.png" alt-text="Flow permissions.":::

When you run the **Run flow** action, flows are run within the embedded flow widget on Omnichannel for Customer Service.

   :::image type="content" source="../media/run-flow.png" alt-text="Run Flow.":::

## Built-in

The Built-in control allows you to run a macro action step based on the conditions. The **Built-in** category connector has a **Condition** action.

   :::image type="content" source="../media/built-in.png" alt-text="Condition connector.":::

To use the **Built-in** category, you first need to have a trigger (predefined automation actions). That is, select a predefined automation action first, and before or after a step, you can define the condition. You can also create nested conditions as per your requirements.

Using the **View run history** option for a particular macro, you can see the condition that was run and whether it succeeded.

For example, you want to open a new form and save it after entering the fields. If the **Product** field in the form has **Surface** as the value, evaluate it as true and then perform the knowledge base article search with the search phrase as **Surface**. If it is evaluated as false, don't perform any further actions.

   > [!div class=mx-imgBorder] 
   > ![Macro conditional builder.](../media/macro-condition.png "Macro conditional builder")

## Use the automation dictionary to pass macro context data parameters

Macros are a set of configured actions that are run on demand by users. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to provide certain data parameters keys. When an agent runs the macro, these data parameters keys are replaced by contextual values.

To learn about the slugs for productivity tools, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-agent-scripts).

To learn more, see [Use automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros-and-agent-scripts).

## Create a macro

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Agent experience**, select **Productivity**.
    
    1. For **Macros**, select **Manage**.

   ### [Omnichannel admin center (deprecated)](#tab/omnichanneladmincenter)

    [!INCLUDE[oac-deprecation](../../includes/oac-deprecation.md)]

    1. In the site map, in **Advanced settings**, select **Agent experience**.
    
    1. For **Macros**, select **Manage**.

1. On the page that appears, select **New**.

1. On the **Macros** page, specify the following.

    | Field | Description | Example value |
    |-------------|-----------------------------------|------------------------------------|
    | Name | Provide a name to the macro. The name is displayed to the agent at runtime. | Create case |
    | Description | Describe the purpose of the macro. The description is displayed to the agent at runtime. | This macro action is used to create a case. |

1. On the **Preferred automation actions** tab, select **Start macro execution**, and then select **New step**.

   :::image type="content" source="../media/create-macro1.png" alt-text="Create a macro.":::

   1. Select a connector from the list. The following connectors are available:

      - [Productivity Automation](#productivity-automation)
      - [Session Connector](#session-connector)
      - [Omnichannel Connector](#omnichannel-connector)

   1. Select an action from the list of actions. You can add as many actions as you need, based on your business requirements.

      If you select **Productivity Automation**, you'll see the following actions.

      | Purpose | Action name |
      |-----------------------------|---------------------------------------------|
      | Open a new form to create a record | Create new |
      | Open an existing form | Open form |
      | Open a record grid | Open grid |
      | Search the knowledge base for the populated phrase | Search knowledge articles |
      | Do a relevance search based on the phrase | Search |
      | Update an existing record | Update record |
      | Open an email form with predefined template | Open email |
      | Resolve a case | Resolve case |

       :::image type="content" source="../media/macro-actions.png" alt-text="Macro actions.":::


      For example, select **Open a new form to create a record**, and the step appears. More information: [Productivity automation](#productivity-automation).

      If you select **Session connector**, you'll see the following actions.

      | Purpose | Action name |
      |-----------------------------|---------------------------------------------|
      | Refresh the application tab | Refresh tab |
      | Focus on a particular application tab from another application tab| Focus tab |
      | Get the details of the current application tab | Get current tab |

      :::image type="content" source="../media/macro-session-connector.png" alt-text="Macro actions for session.":::

      More information: [Session connector](#session-connector)

      If you select **Omnichannel connector**, you'll see the following actions.

      | Purpose | Action name |
      |-----------------------------|---------------------------------------------|
      | Link a record to the conversation while interacting with the customer | Link record to the conversation |
      | Unlink a record from the conversation while interacting with the customer | Unlink record from the conversation |

      :::image type="content" source="../media/macro-omnichannel-connector.png" alt-text="Macro actions for Omnichannel."

      More information: [Omnichannel connector](#omnichannel-connector)
   
       > [!Note]
       > Omnichannel connector is not available in Customer Service workspace.

1. Specify the values in the fields. To learn how to specify the values, see [Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md).

   If you selected **Open a new form to create a record**, you can select **Show advanced options** to add the attributes and values you want. If required, you can select **Add new item** to add more attributes.

   :::image type="content" source="../media/macro-fields.png" alt-text="Attributes for Open a new form to create a record.":::

1. After you add an action step, to define conditions, select the **Built-in** tab, and select **Control**.

1. Select **Condition** to define the conditions. The condition has **If true** or **If false**. Define the condition as per your requirement.

1. To add another action step, repeat step 7 and optionally step 8.

1. Select **Save and close**.

Now, when the agent runs the macro, the actions will be run by fetching the data parameter keys according to the context available from the sources. More information: [Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md).

## View macro run history

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../../includes/cc-omnichannel-administration-deprecation-note.md)]

As an administrator, you can view the macro run history, which shows how many times a macro has been run, along with the success or fail status. When you select a macro that failed, you can view the exact action step at which the failure occurred.

1. Go to the **Macros** page, and select the macro for which you want to view the history.

1. Select **View run history**.

   :::image type="content" source="../media/macro-run-history.png" alt-text="View the run history for a macro.":::

1. Select the macro that failed from the list.

   :::image type="content" source="../media/macro-run-history-list.png" alt-text="Select the macro that failed.":::

1. See the macro action step that caused the failure. Review the previous step for any issue in the slug data parameters that might've been passed incorrectly or slug data parameters that were updated incorrectly.

   :::image type="content" source="../media/macro-run-history-fail.png" alt-text="Review the macro action steps.":::
   > [!div class=mx-imgBorder]

   For example, when you select on the **Open a new form to create a record** step, select **Show more**, and you can view that the mandatory fields don't have values, which are mandatory to save the record. Due to this reason, the macro run failed at the **Save the record** step.

   :::image type="content" source="../media/macro-run-history-fail-reason.png" alt-text="Review the macro action steps to understand failure reason.":::

1. Fix the macro step action that you think might have caused the failure, and then try running it again. For example, since the values are not resolved, go to the macro designer and then check on the slugs, and then try running the macro again.

   > [!Note]
   > If the issue persists, contact Microsoft support.

### See also

[Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md)  
[Agent scripts](agent-scripts.md)  
[Smart Assist](smart-assist.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
