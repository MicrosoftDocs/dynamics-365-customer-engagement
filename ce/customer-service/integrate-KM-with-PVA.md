---
title: "Integrate knowledge management with Power Virtual Agents bot| MicrosoftDocs"
description: "Learn about the integration of knowledge management with Power Virtual Agents bot."
ms.date: 01/14/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
---

# Integrate knowledge management with a Power Virtual Agents bot

## Introduction

Power Virtual Agents let you create powerful chatbots, configured with various topics and trigger phrases, that help automatically resolve questions posed by your customers on your portal page. More information: [Power Virtual Agents overview](/power-virtual-agents/fundamentals-what-is-power-virtual-agents).

Integrating Power Virtual Agents with knowledge management makes it easier to use customized conversations in your chatbot that helps answer questions, perform actions, and solve issues. This frees up your agent’s time to deal with more complex issues.

There are two ways to integrate knowledge management with a Power Virtual Agents bot.

- Manually integrate a Power Virtual Agents bot to assist in knowledge management
- Integrate the Power Virtual Agents solution with knowledge management

## Manually integrate a Power Virtual Agents bot to assist in knowledge management

1. Create and publish knowledge articles to a portal created in Power Apps.
2. Create a topic for the Power Virtual Agents bot, and add an action.
3. Use a Power Automate template to add the solution to the bot.
4. Test the flow to publish and share the bot.

### Create and publish knowledge articles

Set up your portal with the Power Apps portals feature before integrating knowledge management with the Power Virtual Agents bot. More information: [Use settings to set up knowledge management](set-up-knowledge-management-embedded-knowledge-search.md). For more information on setting up your Power Apps portal, see : [Power Apps portal documentation](/powerapps/maker/portals/).

You can create and manage knowledge articles by setting the **Internal** field to **No**. More information: [Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md)

### Create a topic for the Power Virtual Agents bot, and add an action

The system fallback topic can help agents present answers to customers when the knowledge search doesn't provide relevant knowledge articles. You can create the fallback topic and add an action. The action allows the fallback topic to be displayed as a message to agents.

1. Sign in to Power Virtual Agents.

2. Select **New bot**. More information: [Create and delete bots](/power-virtual-agents/authoring-first-bot)

3. Select **Topics** to see the knowledge articles and topics that are provided by the bot.

4. Select **Settings** > **System Fallback**.

5. Select **Add**.

6. After the topic is added, select **Go to Fallback topic** to author the topic.

7. On the authoring canvas, delete the **Escalate** item by selecting **Options.**

    > [!div class="mx-imgBorder"]
    > ![Author a fallback topic.](media/escalate-fallback-KM-PVA.png "Author a fallback topic")

8. Select the connector flowing to the message box, and then select **Call an action** > **Create a flow**.

    > [!div class="mx-imgBorder"]
    > ![Create a flow to call an action.](media/create-a-flow-KM-PVA.png "Create a flow to call an action")

The Power Automate application opens on a new tab, where you'll configure the template settings.

### Use the Power Automate template to add the solution to the flow

Use the Power Automate template that you created to connect to the knowledge base by performing the following steps:

1. On the Power Automate page, select **Templates**, and on the pop-up window that appears, select **Leave** to exit the current page.
 
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

#### Add the solution's flow to the Power Virtual Agents bot

1. Open the browser with the authoring canvas.

2. Above the **Message** action box, select the connector, and then select **Call an action**.

3. From the flow pop-up window, select the new flow named **Generate answer from Dataverse knowledge articles for Power Virtual Agent**. The new action appears in the flow.

4. To correctly set the input variable to the action, select **Select a variable**, and then select **bot.UnrecognizedTriggerPhrase**.

     > [!div class="mx-imgBorder"]
     > ![Add flow to Power Virtual Agents.](media/bot-KM-PVA.png "Add flow to Power Virtual Agents")

5. To return the knowledge article search results to the bot, follow one of these steps:

    - To correctly set the output variable to the **Generate answer from Dataverse knowledge articles for Power Virtual Agent** action, select **UnrecognizedTriggerPhrase** from the **Message** action box. Select the drop-down box next to {x} to insert a variable. Select  **textResult**, which contains the article result in text format. This will render the whole article content as text in the message.

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
                            "text": "${dialog.currentarticle.title}",
                            "wrap": true,
                            "size": "Large"
                        },
                        {
                            "type": "TextBlock",
                            "spacing": "None",
                            "text": "Last modified on ${dialog.currentarticle.modifiedon}",
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
            "url": "${dialog.currentarticle.articleurl}"
        }
    ],
    "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.0"
}
```

### Test and publish the Power Virtual Agents bot

After you've saved the fallback topic, you can test your bot by typing some queries. If an existing topic can't answer the question, the topic that you created is displayed as a message. After publishing the Power Virtual Agents bot, you can also share your bot.

  > [!div class="mx-imgBorder"]
  > ![Test flow.](media/test-flow-KM-PVA.png "Test flow")

To publish the Power Virtual agent bot, select **Publish** and look for the demo link that you'll find on the same page.

You can share the demo by configuring it as a channel: 

1. Select **Manage** > **Channel**.

2. From the list of channels, select **Demo website**.

3. Copy the link, and then select **Save**.
 
## Integrate the Power Virtual Agents solution with knowledge management

1. Create and publish knowledge articles to a portal created in Power Apps.  
2. Create a topic for the Power Virtual Agents bot, and add an action.
3. Configure connection references.
4. Use the Search Knowledge Articles dialog as an action within a custom topic.

### Create and publish knowledge articles to a portal created in Power Apps

More information: [Create and publish knowledge articles](#create-and-publish-knowledge-articles)

### Create a topic for the Power Virtual Agents bot, and add an action

More information: [Create a topic for the Power Virtual Agents bot, and add an action](#create-a-topic-for-the-power-virtual-agents-bot-and-add-an-action)

### Configure connection references

After the solution is imported to the environment, you must configure the connection references. To configure the connection references:

1. Select the notification. A form to configure connection references appears.

:::image type="content" source="media/con-ref-notification.png" alt-text="Connection reference notification":::

2. Configure the connection references.

:::image type="content" source="media/con-ref.png" alt-text="Connection References page"::: 

3. Go to the knowledge article solution and turn on the **Search knowledge article flow**.

:::image type="content" source="media/ka_art_on.png" alt-text="Turn search knowledge article flow to on"::: 

### Use the Search Knowledge Articles dialog as an action within a custom topic

1. Within the topic, create a question node to ask user to search for input text.

:::image type="content" source="media/question_node.png" alt-text="Create a question node":::

2. Go to your chatbot and create a new topic. You can also set optional filter text in a variable.

3. Select **Add node** and select **Call an action**. Select **Search Knowledge Articles Flow**.
 
4. Provide the input to the flow.

:::image type="content" source="media/search_ka_flow.png" alt-text="Search knowledge article flow"::: 

5. Add a message node to show the results returned by the flow.

:::image type="content" source="media/mesg_node.png" alt-text="Message node"::: 

6. Select **Save**. An error might appear if filter is not provided to the flow.

7. Use the trigger phase and run the topic.

8. After the topic is configured, replace the **Search Knowledge Articles Flow** with the **Search Knowledge Articles Dialog**.

:::image type="content" source="media/final_search_ka_dialog.png" alt-text="Replace with search knowledge articles dialog"::: 

9. Update the message node with the output from the extended topic and select **Save**.


### See also

[Create and edit topics](/power-virtual-agents/authoring-create-edit-topics)
