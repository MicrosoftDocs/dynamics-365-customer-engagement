---
title: Manage Customer Knowledge Management Agent
description: Learn how to manage the Customer Knowledge Management Agent to autonomously create knowledge articles from cases and related communications.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 04/23/2026
ms.custom: bap-template
---

# Manage Customer Knowledge Management Agent

Customer Knowledge Management Agent lets you autonomously turn cases and case-related conversations, emails, and notes into knowledge articles that can support your contact center operations. 

## Prerequisites

- You're using the out-of-the-box case or conversation entities, or a custom Dynamics entity for your cases. 
- [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management) is configured.
- You enabled Copilot to access Dynamics 365 knowledge base. You can utilize the internal knowledge base resources only for generating responses. Learn more in [Configure knowledge sources](/dynamics365/contact-center/administer/copilot-enable-help-pane#configure-knowledge-sources?toc=/dynamics365/customer-service/administer/toc.json&bc=../../breadcrumb/toc.yml).
- You [set up pay-as-you-go](setup-pay-as-you-go.md#set-up-pay-as-you-go).
- Set up flow connections for Dataverse and Copilot Studio integration:

    When you navigate to the Customer Knowledge Management Agent page in Copilot Service admin center, a **Prerequisites** section appears at the top of the page that indicates whether connection references are set up. You need to configure connection references for Customer Knowledge Management Agent flow to integrate with Microsoft services. These connections link flow to essential data sources such as Microsoft Dataverse and Copilot Studio, ensuring smooth operation and enhanced functionality.
    
    1. In Copilot Service admin center, go to **Support experience** > **Knowledge**.
    1. Select **Manage** for **Customer Knowledge Management Agent**. The **Customer Knowledge Management Agent** page appears.
    1. In the **Prerequisites** section, for **Step 1: Connection References**, select **Setup connections**.
    1. In the **Configure Connections** dialog, select **Update connection references to use your connector** to update connection references.
    1. In **Step 2: Power Automate Flows**, select **Enable**.
    1. Once all tiles show as **Ready**, select **Publish** in **Step 3: Copilot Studio Agent** to complete the setup.
    
    If you have issues configuring connection references from the **Customer Knowledge Management Agent** page, you can do a manual setup. Follow the steps provided in [Connection references for Customer Knowledge Management Agent flow](admin-km-agent-connections.md#set-connection-references-for-ai-agent-flow).


## Enable Customer Knowledge Management Agent

In Copilot Service admin center, go to **Support experience** > **Knowledge** > **Customer Knowledge Management Agent**, and then select **Manage**. The **Customer Knowledge Management Agent** page appears.

You can harvest knowledge articles from cases, conversation summaries associated to the cases, emails, notes, and conversations. For cases and conversations, select from the options in the following sections as required for Customer Knowledge Management Agent.

## Enable real-time knowledge creation

- For cases, go to the **Case** tab, and in the **Real-time creation** section, select the **Let Copilot use information from current case to create knowledge articles** option. 

- For conversations, go to the **Conversations** tab, and in the **Real-time creation** section, select the **Let Copilot use information from current chat and messaging conversations to create knowledge articles** option.

Real-time knowledge creation is triggered when a customer service representative (service representative) resolves a case or closes a conversation. The agent determines whether a new knowledge article is needed by comparing the content of the case or conversation with the existing knowledge articles in Dynamics 365 knowledge base. If an article is required, the Customer Knowledge Management Agent creates the article using the case or conversation content.  

### Manage rules for real-time article creation  

Create multiple rules to specify the conditions that Customer Knowledge Management Agent must meet to process a resolved case or closed conversation in real time. For example, you might limit this process to cases or conversations owned by a certain user, or any other fields on the case or conversation. 

1. From the **Case** or **Conversations** tab, in the **Real-time creation** section, select **Manage rules**. 
1. In the **Manage rules** dialog, select **New** to add a new rule.
1. In the **New knowledge creation rules** dialog, enter a rule name, condition name, and then add your conditions.
1. Select **Save**.

### Manage case attributes used to create knowledge articles

Customer Knowledge Management Agent uses **Case Title**, **Case Description**, **Product**, **Subject**, **Email Content**, **Conversation Summary**, and **Case Notes** to create an article. You can modify all the fields except **Email Content** and **Conversation Summary**. You can't change the attributes used for conversations.
 
1. In the **Case** section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select **Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.

Case attribute selections are applicable to both historical and real-time creation from cases. 

### Enable track changes and add mapped entities to the Entity Analytics Config table

To avoid issues during knowledge article creation from historical data, we recommend that you enable **Track changes** for the mapped entities and add them to the **Entity Analytics Config** table.

1. [Enable track changes](/power-platform/admin/enable-change-tracking-control-data-synchronization#using-power-apps-settings).
2. To add mapped entities to the **Entity Analytics Config** table:
    
    1. Open the model-driven app ( `https://<org>.crm.dynamics.com/...` ).   
    2. Press **F12** to open the browser’s **Developer Tools**, and then select the **Console** tab.   
    3. Copy the following script snippet, update **ENTITY_NAME**, and paste it into the console.
    4. Press **Enter** to run the script.
    
    ```javascript
    
    Xrm.WebApi.createRecord('entityanalyticsconfig', {'parententitylogicalname':'{ENTITY_NAME}','isenabledforadls': true})
    
     ``` 

### Enable real-time knowledge harvesting for a custom record type

Enable real-time knowledge harvesting for custom record types in Dynamics 365. Add a trigger button and surface the harvested knowledge articles in your custom table.

1. [Create the custom table](/power-apps/maker/data-platform/create-edit-entities-portal?tabs=excel) in [Power Apps](https://make.powerapps.com/). If the table already exists, ensure it contains attributes that map to case descriptions and resolutions from which knowledge can be harvested. 
1. [Add record types for which you want to turn on knowledge management](configure-knowledge-search-control-productivity-pane.md).
1. [Add custom record types (preview)](#add-custom-record-types-preview).
1. Enable real-time knowledge creation:
    1. [Configure knowledge search control on app side pane for an entity record](configure-knowledge-search-control-productivity-pane.md).
    1. Ensure your custom table (for example, **Custom_Knowledge_Harvest**) appears as a tab, similar to Case or Conversation. 
1. [Configure rules for real-time article creation](#manage-rules-for-real-time-article-creation) specifically for your custom record tab.
1. Configure which attributes from your table are used to generate knowledge articles.
1. [Add a trigger harvesting button](#add-a-trigger-harvesting-button) to your custom table form.
1. Navigate to your custom table (for example, **Custom_Knowledge_Harvest**).
1. Open an existing record. The **Trigger Harvesting** button appears on the **Command** bar.
1. Select the button to trigger knowledge harvesting for the current record. A confirmation dialog appears, indicating that the knowledge harvest is triggered successfully.

### Add a trigger harvesting button

Add a trigger harvesting command button to your custom table's main form using Power Apps Command Designer to enable real-time knowledge harvesting for your custom records.

The JavaScript triggers knowledge harvesting by sending table and user information to the API, displays progress indicators, handles responses, and controls button availability based on the form state. The button works similarly to Case and Conversation record types.

> [!NOTE]
> The following example is a sample implementation to trigger knowledge harvesting through a button click. You can customize the button behavior and JavaScript logic based on your organization's requirements.

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select **Tables** from the left navigation pane.
1. Find and select your custom table (for example, **Custom_Knowledge_Harvest**).
1. Select [Edit the command bar](/power-apps/maker/model-driven-apps/use-command-designer#edit-the-command-bar) and then select **main form**. Learn more in [Command bar locations](/power-apps/maker/model-driven-apps/command-designer-overview#command-bar-locations).
    1. In the right pane, enter a label that displays on the command button and select an icon for the command button.
    1. Under **Action**, provide the following JavaScript library and command to run the command action. Learn more in [Use JavaScript for actions](/power-apps/maker/model-driven-apps/use-command-designer#use-javascript-for-actions). 

    ```javascript 
    
    /**
     * Knowledge Harvest Trigger - Command Bar Button Handler
     * This script provides functionality to trigger Knowledge Harvesting for custom entities.
     */
    var Msdyn = Msdyn || {};
    Msdyn.KnowledgeHarvest = Msdyn.KnowledgeHarvest || {};
    
    (function () {
        "use strict";
    
        Msdyn.KnowledgeHarvest.triggerHarvest = function (primaryControl) {
            var formContext = primaryControl;
            var entityId = formContext.data.entity.getId();
            if (entityId) {
                entityId = entityId.replace("{", "").replace("}", "");
            }
    
            var entityName = formContext.data.entity.getEntityName();
            var globalContext = Xrm.Utility.getGlobalContext();
            var userId = globalContext.userSettings.userId;
            if (userId) {
                userId = userId.replace("{", "").replace("}", "");
            }
    
            var payload = JSON.stringify({
                "entityname": entityName,
                "entityrecordid": entityId,
                "initiatinguserid": userId
            });
    
            Xrm.Utility.showProgressIndicator("Triggering Knowledge Harvest...");
    
            var request = {
                Payload: payload,
                getMetadata: function () {
                    return {
                        boundParameter: null,
                        operationName: "msdyn_knowledgeHarvestAgentTrigger",
                        operationType: 0,
                        parameterTypes: {
                            "Payload": {
                                typeName: "Edm.String",
                                structuralProperty: 1
                            }
                        }
                    };
                }
            };
    
            Xrm.WebApi.online.execute(request).then(
                function (response) {
                    Xrm.Utility.closeProgressIndicator();
                    if (response.ok) {
                        Xrm.Navigation.openAlertDialog({
                            title: "Knowledge Harvest Triggered",
                            text: "Knowledge Harvest has been triggered successfully.\\nA job has been created to generate a knowledge article.",
                            confirmButtonLabel: "OK"
                        });
                    } else {
                        throw new Error("API call failed with status: " + response.status);
                    }
                }
            ).catch(
                function (error) {
                    Xrm.Utility.closeProgressIndicator();
                    console.error("Knowledge Harvest Trigger Error:", error);
                    Xrm.Navigation.openAlertDialog({
                        title: "Knowledge Harvest Error",
                        text: "Failed to trigger Knowledge Harvest.\\nError: " + error.message,
                        confirmButtonLabel: "OK"
                    });
                }
            );
        };
    
        Msdyn.KnowledgeHarvest.enableHarvestButton = function (primaryControl) {
            var formContext = primaryControl;
            var entityId = formContext.data.entity.getId();
            if (!entityId || entityId === "" || entityId === "{}") {
                return false;
            }
    
            var formType = formContext.ui.getFormType();
            if (formType === 1) {
                return false;
            }
    
            return true;
        };
    })();
    
    ``` 
    1. In the **Add JavaScript Library** dialog, select the JavaScript library you created.
    1. Add the library to your command.
    1. For function name, enter **Msdyn.KnowledgeHarvest.triggerHarvest**.
    1. Select **+ Add** parameter, and in **Parameter 1**, select **PrimaryControl** from the dropdown.

1. Under **Visibility**, keep the default setting as **Show** or configure custom visibility rules based on your requirements.
1. Drag and drop the command to the desired location. 
1. Save and publish to make the command available to app users.

## Enable historical knowledge creation

When enabled, the agent considers all the cases and conversations that meet the specified conditions and then determines if new articles are needed by comparing the content of the cases or conversations with the existing knowledge base. The agent then creates a new article, if necessary, based on the content of the cases and conversations. You can also [add custom record types (preview)](#add-custom-record-types-preview) that Customer Knowledge Management Agent can use to create new knowledge articles.

1. Select the **Cases**, **Conversations**, or the **Custom record types (preview)** tab.

    1. For cases, in the **Creation from historical cases** section, select the **Let copilot use information from historical cases to create knowledge articles** option.
    
    1. For conversations, in the **Creation from historical conversations** section, select the **Let copilot use information from historical chat and messaging conversations to create knowledge articles** option.
    
    1. For custom record types, in the **Custom record type** section, select the **Let copilot use information from historical custom record types to create knowledge articles** option.

1. Select **Manage rules** to configure the conditions for the harvest.
1. On the **Default rule** dialog, enter a rule name, condition name, and then add your conditions to filter historical articles. You might also specify a custom article template to be used for this rule. 
1. Select **Save**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.
1. Select **Start** on the **Creation from historical cases, conversations, or custom record types** section. 
Once you select start, you see that the article creation is in progress. You can see the creation process log by selecting the **View creation process log** link.

Historical case or conversation creation is a long-running process that can't be stopped once it starts. The process can create articles from up to 100,000 individual cases or conversations and continues until all are processed. We recommend performing historical knowledge creation in batches. 

### Add custom record types (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

Add custom record types that Customer Knowledge Management Agent can use to create new knowledge articles. 

To add a custom record type: 

1. [Turn on knowledge management for your record type](configure-knowledge-search-control-productivity-pane.md#add-record-types-for-which-you-want-to-turn-on-knowledge-management).
1. In Copilot Service admin center, go to **Support experience** > **Knowledge** > **Customer Knowledge Management Agent**, and then select **Manage**. The **Customer Knowledge Management Agent** page appears.
1. Select **Add record type**. The **Add record type** page appears. 
1. In the **Select record type** dropdown, select the record type you want to create knowledge from.
1. Select **Save and close**.

You can add up to five custom record types.

### Specify a custom article template for historical knowledge creation 

When you set up historical creation rules, you can select a custom article template for new articles. By default, Customer Knowledge Management Agent creates articles in **Issue**, **Cause**, and **Resolution** format. If you [configured knowledge article templates](../use/create-templates-knowledge-article.md#create-templates-for-knowledge-articles), you can specify one template per rule. 

When you specify a custom article, Customer Knowledge Management Agent uses the template sections, section instructions, and styles to create the new article. Use the following best practices for your template: 

- Include only content sections in the template; exclude metadata fields (for example, avoid fields like Article Creation Date).
- Provide a detailed description for each section, explaining the type of content expected.
- Clearly indicate which fields are required and which are optional within the template.
- If categorization is needed, include the list of category options directly in the template.
- Clearly separate any compliance text (for example, add a note such as "Don't edit below this line.").
- Use a consistent format for placeholders and variables, such as {{ProductName}} or {{ErrorCode}}.
- Where possible, include a minimal, well-structured example within the template to guide users.

## Manage more record type attributes used to create knowledge articles

Customer Knowledge Management Agent uses **Title**, **Description**, **Product**, **Subject**, **Email Content**, and **Case Notes** to create an article. You can modify all the fields except **Email Content**, **Incident Resolution, and **Conversation Summary**. 
 
1. In your custom record type section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select **Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page. 

## Configure automatic article updates (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

Customer Knowledge Management Agent can automatically apply minor updates to existing knowledge articles. By default, Customer Knowledge Management Agent creates a new minor version of the article.

To enable automatic minor updates of articles, on the **Customer Knowledge Management Agent** page, in the **Automatic article updates** section, select the **Automatically update existing articles (preview)** option.

## Set the default compliance state of created articles

You can set the default compliance state for articles and their updated versions, created by the Customer Knowledge Management Agent. For example, to maintain compliance, set the default state to **Pending** and have knowledge reviewers mark the articles as compliant before publishing.  

To set the default compliance state of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent** page, **Compliance** section, select your default compliance state from the available options.

Articles with the **Noncompliant** status can't be published.

> [!NOTE]
> Customer Knowledge Management Agent removes personal data from the case data before drafting articles. However, the agent might not detect all instances of sensitive information.

## Auto publish articles

You can configure whether the AI agent can automatically publish articles and minor updates that meet the specified **Compliance** status. You can also select the target audience that can view the published articles.

To set the autopublishing of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent** page, **Auto publishing** section, select the **Automatically publish compliant articles as soon as they’re created** option.

- Select **Internal target audiences**, if you want articles to be available to your service representatives and Copilot internally. 
- Select **Internal and external target audiences**, if you want these articles to be published to external portals.

## Set up the agent review draft experience

If you’re not configuring the AI agent to automatically publish articles, you can configure an agent review experience where service representatives can review and publish articles.

To enable this editor: 

- Enable in-app notifications for service representatives to be notified when their cases are considered for publishing.
- Ensure that your service representatives have the permission to edit articles.
- Make sure that your cases have **Timeline** and **Timeline highlights** enabled.

Service representatives can see whether they have knowledge articles to review by opening a resolved case. Learn more in [Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent).

## Use knowledge insights for Customer Knowledge Management Agent

You can get analytics reports on Customer Knowledge Management Agent and collect analytics data for your own custom reporting. Learn more in [Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent).

## Related information

[Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent)  

[Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent)
