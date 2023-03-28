---
title: "Macros in the Customer Service workspace app | MicrosoftDocs"
description: "This topic provides information about the different macros that can be made available to agents and how to configure them in app profile manager."
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.date: 04/05/2023
ms.topic: how-to
ms.custom: bap-template
---

# Automate tasks with macros

In the customer service industry, agents have to click often to perform simple tasks, such as open a form, fill, and save it, and many repetitive and monotonous actions, such as greeting and verifying a customer, sending acknowledgment mail, and taking notes. These clicks and repetitive tasks can lead to human errors when agents copy and paste the data across different operations.

Macros are a set of sequential actions that are performed by a user. They enable users to perform daily operations efficiently in a fast and process-compliant manner. You can reuse macros with different sessions based on the context parameters that are specific to the session.

The value propositions of the macros are as follows:

- Automate repetitive and monotonous tasks with a single click.

- Minimize human errors.

- Adhere to business processes.

- Lower average handling time.

- Improve customer satisfaction.

- Create contextual and reusable macros.

The macros in Customer Service workspace have the following:

- [Predefined automation actions](#predefined-automation-actions)
- [Built-in control](#built-in)

## Prerequisites

- Install Dynamics 365 Productivity Tools solution.

- Ensure that you have the **Productivity tools administrator** security role. More information: [Assign roles and enable users](../customer-service/add-users-assign-roles.md)

- Ensure that agents and supervisors are assigned the **Productivity tools user** security role. More information: [Assign roles and enable users](../customer-service/add-users-assign-roles.md)

## Predefined automation actions

In Customer Service, macros provide three connectors:

- [Productivity automation](#productivity-automation): Provides actions to perform model-driven app operations.

- [Session connector](#session-connector): Provides actions to perform session-related operations.

- [Omnichannel connector](#omnichannel-connector): Provides actions to perform Omnichannel for Customer Service&ndash;related operations.

### Productivity automation

As an administrator, you can use the actions any number of times across different macros to automate and perform model-driven app operations.

The following screenshot shows the actions that are explained in the subsequent sections.
   :::image type="content" source="../customer-service/media/macro-actions.png" alt-text="Macro actions for productivity automation.":::

#### Open a new form to create a record

This action is used to open a new form to create a record. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open.<br> This is a mandatory field. | incident |
   | Entity form ID | Specify the form ID.<br> This is an optional field. |
   | Attribute Name | Specify the attribute logical name. You need to provide the attribute name to prepopulate the field with a value.| |
   | Attribute Value | Specify the attribute value. You need to provide the attribute value to prepopulate the attribute field. | |
  
#### Open an existing record

This action is used to open an existing record form. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to open. <br> This is a mandatory field. | incident |
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| |
   | Entity form ID | Specify the form ID. <br>This is an optional field. | |
  
#### Open a record grid

This action is used to open a record grid. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity for which you want to open the grid. <br> This is a mandatory field. | incident |
   | View ID| Specify the ID of the view that you want to open.<br> This is a mandatory field. | |
   | View type | Specify the view type. <br>This is a mandatory field. | |
   |||

#### Search the knowledge base for the populated phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to search for knowledge articles. You can provide the context data. For example, the context data parameter can be a case title. |  |
   |Tab Label| Specify the tab label.|

#### Do a relevance search based on the phrase

This action is used for searching knowledge articles based on the populated phrase. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Search string |  Provide the phrase based on which you want to do a relevance search. You can provide the context data. For example, the context data parameter can be a case title. <br> This is a mandatory field.  |  |
 
#### Update an existing record

This action is used to update an existing record. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | incident |
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| |
   | Attribute Name | Specify the attribute logical name you want to update.| |
   | Attribute Value | Specify the attribute value that will be updated for the above-mentioned attribute. | |

#### Set Agent Script focus

This action is used to set the focus to an agent script that needs to run next. The agent script will be set in focus in the **Agent scripts** dropdown on the app side pane. For example, if the agent needs to process a refund complaint. The agent will use different scripts to greet, initiate a complaint request, and process the refund. You can define macros that will set the focus on the agent scripts that need to be run for each stage of the refund process. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Agent Script Unique Name   |  Specify the agent script that needs to be in focus.  |  The unique name of the agent script.  |

#### Open an email form with predefined template

This action is used to open an email with a predefined template. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name |  Specify the logical name of the entity. <br> This is a mandatory field. | incident |
   | Entity record ID| Specify the entity record ID. <br>This is a mandatory field.| |
   | Email recipients | Specify the recipients to whom you want the mail to be sent. <br> This is a mandatory field. | |
   | Template ID | Specify the ID of the template that must displayed in the email. <br> This is a mandatory field. | |


#### Resolve a case

This action is used to resolve a case. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Billable time |  Specify the time that is billable. <br> This is a mandatory field. | incident |
   | Incident ID| Specify the ID of the case that you want to close. <br>This is a mandatory field.| |
   | Resolution | Specify the reason to resolve the case. <br> This is a mandatory field. | |


#### Autofill form fields

This action is used for updating the form attribute (field). The action updates the attribute of a form if that form is currently in focus and has the same entity type as mentioned in action. If the action is run for any other entity, then the action will fail. Also, the action only updates the field and doesn't save the record. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to update. <br> This is a mandatory field. | incident |


#### Clone current record

This action is used for cloning an existing record that is open in the current tab. The action only copies the fields and does not save the record. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Record title | Specify the title of the record that you want to clone. <br> This is a mandatory field. | |


#### Open knowledge base article

This action is used to open the knowledge base article. The action contains the following field.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity record ID  | Specify the entity ID of the knowledge base article that you want to open. <br> This is a mandatory field.|  |


#### Save the record

This action saves the record after you've entered data in all the mandatory fields. The action fails if the mandatory fields aren't entered or are left blank.

#### Clone input record

This action clones an existing record. The action only copies the fields and does not save the record. The action contains the following fields.

   | Field | Description | Parameter |
   |-----------------|-----------------------------|--------------------------|
   | Entity logical name | Specify the logical name of the entity that you want to clone. <br> This is a mandatory field. |
   | Entity record ID | Specify the ID of the entity record. <br> This is a mandatory field.|
   |Record title| Specify the record title.


### Session connector

As an administrator, you can use the actions any number of times across different macros to automate and perform operations related to a session in Customer Service workspace.


   > [!div class=mx-imgBorder] 
   > ![Macro actions for session connector.](../customer-service/media/macro-session-connector.png "Macro actions for session connector")

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

   > [!div class=mx-imgBorder] 
   > ![Macro actions for Omnichannel connector.](../customer-service/media/macro-omnichannel-connector.png "Macro actions Omnichannel connector")

#### Send KB article in chat

This action pastes a knowledge base article in the conversation chat window. It must be used with the **Search knowledge base for the populated phrase** action. The action contains the following field.

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


   > [!div class=mx-imgBorder]
   > ![Macro actions for flow connector.](../customer-service/media/macro-flow-connector.png "Macro actions for flow connector")

#### Run Flow

This action triggers Power Automate flows using macros in agent scripts. This action contains the following fields.

| Field                | Description                             | Parameter  |
|----------------------|-----------------------------------------|------------|
| Entity logical name | Specify the logical name of the entity that you want to link. This is a mandatory field. Any Microsoft Dataverse entity, such as Account, can be used based on business needs. | account   |
| Entity record id     | Specify the entity record ID of the entity that you want to link. This is a mandatory field. Ids or slugs, such as {customerRecordId}, can be used. While this field is labeled as entity record id, any value to be processed can be passed. While the field is required, values do not have to be functional unless required for the flow logic. | {customerRecordId}   |
| Select flow         | Specify or select the Power Automate flow to be run by this action. Requires instant cloud flows with *When a record is selected* flow triggers. Existing flows with proper permissions will be detected and displayed in the drop-down list. |    |

#### Power Automate flow permissions

Referenced flows require valid connection and run permissions for the Omnichannel for Customer Service and Customer Service workspace tenant and agents that run the flow from within agent scripts.

   > [!div class=mx-imgBorder] 
   > ![Flow permissions.](../customer-service/media/flow-permissions.png "Flow permissions")

When you run the **Run flow** action, flows are run within the embedded flow widget on Omnichannel for Customer Service.

   > [!div class=mx-imgBorder] 
   > ![Run Flow.](../customer-service/media/run-flow.png "Run Flow")


## Built-in

The Built-in control allows you to run a macro action step based on the conditions. The **Built-in** category connector has a **Condition** action.

   > [!div class=mx-imgBorder] 
   > ![Condition connector.](../customer-service/media/built-in.png "Condition connector")

To use the **Built-in** category, you first need to have a trigger (predefined automation actions). That is, select a predefined automation action first, and before or after a step, you can define the condition. You can also create nested conditions as per your requirements.

Using the **View run history** option for a particular macro, you can see the condition that was run and whether it succeeded.

For example, you want to open a new form and save it after entering the fields. If the **Product** field in the form has **Surface** as the value, evaluate it as true and then perform the knowledge base article search with the search phrase as **Surface**. If it is evaluated as false, don't perform any further actions.

   > [!div class=mx-imgBorder] 
   > ![Macro conditional builder.](../customer-service/media/macro-condition.png "Macro conditional builder")

## Use the automation dictionary to pass macro context data parameters

Macros are a set of configured actions that are run on demand by users. As an administrator, you need to configure the actions that a macro must perform. To configure the actions, you need to provide certain data parameters keys. When an agent runs the macro, these data parameters keys are replaced by contextual values.

To learn about the slugs for productivity tools, see [Slugs](automation-dictionary-keys.md#slugs-for-productivity-tools-macros-and-agent-scripts).

To learn more, see [Use automation dictionary to pass data parameter keys](automation-dictionary-keys.md#pass-data-parameter-in-macros-and-agent-scripts).

## Create a macro

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    
    1. In the site map, in **Agent experience**, select **Productivity**.
    
    1. For **Macros**, select **Manage**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    1. In the site map, in **Advanced settings**, select **Agent experience**.
    
    1. For **Macros**, select **Manage**.

   ### [App profile manager](#tab/appprofilemanager)

    1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and go to the app profile manager page.

    1. In the left pane, under **Productivity**, select **Agent scripts**. The Unified Interface page opens on a new tab.

1. On the page that appears, select **New**.

1. On the **Macros** page, specify the following.

    | Field | Description | Example value |
    |-------------|-----------------------------------|------------------------------------|
    | Name | Provide a name to the macro. The name is displayed to the agent at runtime. | Create case |
    | Description | Describe the purpose of the macro. The description is displayed to the agent at runtime. | This macro action is used to create a case. |

1. On the **Preferred automation actions** tab, select **Start macro execution**, and then select **New step**.

   :::image type="content" source="../customer-service/media/create-macro1.png" alt-text="Create a macro.":::

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

       :::image type="content" source="../customer-service/media/macro-actions.png" alt-text="Macro actions.":::


      For example, select **Open a new form to create a record**, and the step appears. More information: [Productivity automation](#productivity-automation).

      If you select **Session connector**, you'll see the following actions.

      | Purpose | Action name |
      |-----------------------------|---------------------------------------------|
      | Refresh the application tab | Refresh tab |
      | Focus on a particular application tab from another application tab| Focus tab |
      | Get the details of the current application tab | Get current tab |


       > [!div class=mx-imgBorder] 
       > ![Macro actions for session.](../customer-service/media/macro-session-connector.png "Macro actions for session")    

      More information: [Session connector](#session-connector)

      If you select **Omnichannel connector**, you'll see the following actions.

      | Purpose | Action name |
      |-----------------------------|---------------------------------------------|
      | Link a record to the conversation while interacting with the customer | Link record to the conversation |
      | Unlink a record from the conversation while interacting with the customer | Unlink record from the conversation |


       > [!div class=mx-imgBorder] 
       > ![Macro actions for Omnichannel.](../customer-service/media/macro-omnichannel-connector.png "Macro actions for Omnichannel") 

       More information: [Omnichannel connector](#omnichannel-connector)
   
       > [!Note]
       > Omnichannel connector is not available in Customer Service workspace.

1. Specify the values in the fields. To learn how to specify the values, see [Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md).

   If you selected **Open a new form to create a record**, you can select **Show advanced options** to add the attributes and values you want. If required, you can select **Add new item** to add more attributes.

   > [!div class=mx-imgBorder] 
   > ![Attributes for Open a new form to create a record.](../customer-service/media/macro-fields.png "Attributes for Open a new form to create a record") 

1. After you add an action step, to define conditions, select the **Built-in** tab, and select **Control**.

1. Select **Condition** to define the conditions. The condition has **If true** or **If false**. Define the condition as per your requirement.

1. To add another action step, repeat step 7 and optionally step 8.

1. Select **Save and close**.

Now, when the agent runs the macro, the actions will be run by fetching the data parameter keys according to the context available from the sources. More information: [Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md).

## View macro run history

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

As an administrator, you can view the macro run history, which shows how many times a macro has been run, along with the success or fail status. When you select a macro that failed, you can view the exact action step at which the failure occurred.

1. Go to the **Macros** page, and select the macro for which you want to view the history.

1. Select **View run history**.

   > [!div class=mx-imgBorder]
   > ![View the run history for a macro.](../customer-service/media/macro-run-history.png "View the run history for a macro")

1. Select the macro that failed from the list.

   > [!div class=mx-imgBorder] 
   > ![Select the macro that failed.](../customer-service/media/macro-run-history-list.png "Select the macro that failed")

1. See the macro action step that caused the failure. Review the previous step for any issue in the slug data parameters that might've been passed incorrectly or slug data parameters that were updated incorrectly.

   > [!div class=mx-imgBorder]
   > ![Review the macro action steps.](../customer-service/media/macro-run-history-fail.png "Review the macro action steps")

   For example, when you select on the **Open a new form to create a record** step, select **Show more**, and you can view that the mandatory fields don't have values, which are mandatory to save the record. Due to this reason, the macro run failed at the **Save the record** step.

   > [!div class=mx-imgBorder]
   > ![Review the macro action steps to understand failure reason.](../customer-service/media/macro-run-history-fail-reason.png "Review the macro action steps to understand failure reason")

1. Fix the macro step action that you think might have caused the failure, and then try running it again. For example, since the values are not resolved, go to the macro designer and then check on the slugs, and then try running the macro again.

   > [!Note]
   > If the issue persists, contact Microsoft support.

### See also

[Use automation dictionary to pass data parameters keys](automation-dictionary-keys.md)  
[Agent scripts](agent-scripts.md)  
[Smart Assist](smart-assist.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
