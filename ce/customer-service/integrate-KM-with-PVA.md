---
title: "Integrate knowledge management with Power Virtual Agents bot| MicrosoftDocs"
description: "Learn about the integration of knowledge management with Power Virtual Agents bot."
ms.date: 01/25/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# Integrate knowledge management with a Power Virtual Agents bot

## Introduction

Power Virtual Agents let you create powerful bots, configured with various topics and trigger phrases, that help automatically resolve questions posed by your customers on your portal page. More information: [Power Virtual Agents overview](/power-virtual-agents/fundamentals-what-is-power-virtual-agents).

Integrating Power Virtual Agents bot with knowledge management makes it easier to use customized conversations in your bot. This frees up your agent’s time to deal with complex issues that need human intervention, as the bot helps answer questions, perform actions, and solve issues that are simple in nature.

You can integrate knowledge management with a Power Virtual Agents bot by using either of the following ways:

- Search Knowledge Articles dialog
- Power Automate flow template

## Prerequisites

- Dataverse search must be enabled for the integration. More information: [Configure Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization)

- You must perform the following two steps before you begin the integration:

  - Create and publish knowledge articles to a portal created in Power Apps.
  
    Set up your portal with the Power Apps portals feature before integrating knowledge management with the Power Virtual Agents bot. More information: [Use settings to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md). For more information on setting up your Power Apps portal, see: [Power Apps portal documentation](/powerapps/maker/portals/).

    You can create and manage knowledge articles by setting the **Internal** field to **No**. More information: [Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md).

  - Create a  Power Virtual Agents bot and a topic in it.

    - For more information on creating a bot, see: [Create and delete Power Virtual Agents bots](/power-virtual-agents/authoring-first-bot)
    - For more information on creating a topic, see: [Create and edit topics in your Power Virtual Agents bot](/power-virtual-agents/authoring-create-edit-topics)
   
## Use the Search Knowledge Articles dialog

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>


You must perform the following steps to integrate knowledge management with a Power Virtual Agents bot using the Search Knowledge Articles dialog:
 
   1. Set connection references
   1. Call the flow as one-time mandatory step
   1. Add the dialog to the PVA topic

### Set connection references

Knowledge PVA solution makes use of the flow which uses connections, such as Content Conversion and Dataverse. You must configure these connection references before turning the **Search knowledge article flow** on. To set connection references:
   
1. Select the notification. A form to configure connection references appears.

     :::image type="content" source="media/con-ref-notification.png" alt-text="Connection reference notification":::

2. Configure the connection references.

     :::image type="content" source="media/con-ref.png" alt-text="Connection References page"::: 

3. Go to the knowledge article solution and turn on the **Search knowledge article flow**.

     :::image type="content" source="media/ka_art_on.png" alt-text="Turn search knowledge article flow to on":::

### Call the flow as one-time mandatory step
    
You must create a topic with two question nodes for search text and filter. For filter, the Power Virtual Agents author can provide a dummy filter value like **statecode eq 3**. This step ensures that flow is properly configured and can now be replaced with **Search knowledge article extended** topic.  
  
1. Within the topic, create a question node to ask the user to search for the input text.

    :::image type="content" source="media/question_node.png" alt-text="Create a question node":::
    
2. Go to your chatbot and create a new topic. You can also set optional filter text in a variable.
    
3. Select **Add node** and select **Call an action**. Select **Search Knowledge Articles Flow**.
     
4. Provide the input to the flow.
    
    :::image type="content" source="media/search_ka_flow.png" alt-text="Search knowledge article flow"::: 
    
5. Add a message node to show the results returned by the flow. More information: [Render results](#render-results) 
    
    :::image type="content" source="media/mesg_node.png" alt-text="Message node"::: 
    
6. Select **Save**. An error might appear if filter is not provided to the flow.
    
7. Use the trigger phase and run the topic.
      
  
### Add the dialog to the PVA topic
   
1. After the topic is configured, replace the **Search Knowledge Articles Flow** with the **Search knowledge articles** dialog.

    :::image type="content" source="media/final_search_ka_dialog.png" alt-text="Replace with search knowledge articles dialog"::: 

2. Update the message node with the output from the extended topic and select **Save**.
  
## Use the Power Automate flow template

You must perform the following steps to integrate knowledge management with a Power Virtual Agents bot using the Power Automate flow template:

1. Create a flow using the template
1. Add the solution's flow to the Power Virtual Agents topic
   
### Create a flow using the template

1. Go to [flow.microsoft.com](/powerautomate.microsoft.com).

2. On the templates page, search for the **Generate answers from Dataverse knowledge articles to Power Virtual Agent** template.

    > [!div class="mx-imgBorder"]
    > ![Create a flow.](media/template-KM-PVA.png "Create a flow")

3. Select **Continue**. You'll be redirected to the Power Automate flow template.

4. Save the template, and then select **Solutions**. You might be prompted with a message on which you can select **OK**.
    
5. Select **New solution**.

6. Enter a display name. The list of solutions includes every solution in your organization. Choose a naming convention that helps you filter to just your solutions. For example, you might prefix your email to your solution name: *johndoe-power-virtual-agent-knowledgesearch-fallback*.
    
7. Select your publisher from the list of choices.
    
8. Accept the default values for name and version.
    
9. Select **Create** to finish the process.
     
    > [!div class="mx-imgBorder"]
    > ![Add a solution.](media/add-solution-KM-PVA.png "Add a solution")
    
10. In the list of solutions, select the solution you just created. It should appear at the top of the list. If it doesn't, search by the convention you used in step 6 to name the solution.
    
11. In the solution, select **Add existing**, and then select **Cloud Flow** from the list.
    
12. In the **Outside solutions** list, select your flow, and then select **Add** to finish the process. If there are several flows, look at the **Modified** column to find the most recent version.

### Add the solution's flow to the Power Virtual Agents topic

1. Open the browser with the authoring canvas.
    
2. Above the **Message** action box, select the connector, and then select **Call an action**.
    
3. From the flow pop-up window, select the new flow named **Generate answer from Dataverse knowledge articles for Power Virtual Agent**. The new action appears in the flow.
    
4. To correctly set the input variable to the action, select **Select a variable**, and then select **bot.UnrecognizedTriggerPhrase**.
    
   > [!div class="mx-imgBorder"]
   > ![Add flow to Power Virtual Agents.](media/bot-KM-PVA.png "Add flow to Power Virtual Agents")
    
5. To return the knowledge article search results to the bot, see [Render results](#render-results).

## Render results
 
To return the knowledge article search results to the bot, follow either of these steps:

- Use thumbnail cards to show the article. More information: [Respond with cards](/composer/how-to-send-cards#thumbnailcard)

- Use the following sample code to render search results in adaptive cards.

#kbcardjson()
```
-  
{ 

  "type": "AdaptiveCard", 

    "body": [ 

        { 

            "type": "ColumnSet", 

            "columns": [ 

                { 

                    "type": "Column", 

                    "items": [ 

                        { 

                            "type": "Image", 

                            "height": "35px", 

                            "url": "https://th.bing.com/th/id/R4fbade037f8209666b06aa22641708fc?rik=ya%2bpnPJ41EFFMg&riu=http%3a%2f%2fmolnar-institute.com%2ffileadmin%2f_processed_%2fcsm_KnowledgeManagement_icon_forWebsite_bcda89676b.png&ehk=J%2bz2G15xtbJgd7ssSXo7X2q7LDLaMGl7EuGUSQU6P2s%3d&risl=&pid=ImgRaw", 

                            "size": "Small" 

                        } 

                    ], 

                    "width": "auto" 

                }, 

                { 

                    "type": "Column", 

                    "items": [ 

                        { 

                            "type": "TextBlock", 

                            "weight": "Bolder", 

                            "text": "${json(virtualagent.jsonResult).articles[0].title}", 

                            "wrap": true, 

                            "size": "Large" 

                        }, 

                        { 

                            "type": "TextBlock", 

                            "spacing": "None", 

                            "text": "Last modified on ${json(virtualagent.jsonResult).articles[0].modifiedon}", 

                            "isSubtle": true, 

                            "wrap": true 

                        } 

                    ], 

                    "width": "stretch" 

                } 

            ] 

        }, 

        { 

            "type": "TextBlock", 

            "text": "${json(virtualagent.jsonResult).articles[0].description}", 

            "wrap": true, 

            "size": "medium" 

        } 

    ], 

    "actions": [ 

        { 

            "type": "Action.OpenUrl", 

            "title": "View article in Dynamics App", 

            "url": "${json(virtualagent.jsonResult).articles[0].crmAppUrl}" 

        } 

    ], 

    "$schema": "http://adaptivecards.io/schemas/adaptive-card.json", 

    "version": "1.0" 

} 
```

### See also

[Create and edit topics](/power-virtual-agents/authoring-create-edit-topics)
