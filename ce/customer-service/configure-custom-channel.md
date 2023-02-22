---
title: Configure custom messaging channel 
description: Learn what a custom channel is and how to configure the channel, or bring your own channel, in Omnichannel for Customer Service.
ms.date: 02/23/2022
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template

---

# Configure a custom messaging channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

As an organization, you want the ability to integrate your line-of-business (in-house) messaging channels or other messaging channels with Omnichannel for Customer Service. You can integrate messaging channels like Direct Line, Kik, and Telegram.

With the custom messaging channel capability, you can:
- Bring in your own channels, so you can engage better with customers.
- Integrate line-of-business (in-house) messaging channels that are specific to your organization.
- Easily configure the administrator experience in the admin app like Customer Service admin center.
- Create a single and unified agent experience in the Omnichannel for Customer Service app.

## Prerequisites

- Have a bot that's built using the [Microsoft Bot Framework](https://dev.botframework.com) and registered with [Azure Bot Service](/azure/bot-service/bot-service-quickstart-registration?view=azure-bot-service-4.0&preserve-view=true). Ensure that you register the bot resource as a multitenant app.
 - [Get the app ID](/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0&tabs=userassigned#to-get-your-app-or-tenant-id&preserve-view=true). 
 - [Get the client secret value](/azure/bot-service/abs-quickstart?view=azure-bot-service-4.0&tabs=userassigned#to-generate-a-new-password&preserve-view=true).


## Configure a custom messaging channel account

1. In Dynamics 365, go to one of the apps, and perform the following steps:
   - Customer Service admin center:
    
      1. In the site map, in **Customer support**, select **Channels**.
      1. In **Accounts**, for **Messaging accounts**, select **Manage**.
   
   - Omnichannel admin center: In the site map, in **General settings**, select **Channels**.

1. On the **Accounts and channels** page, select **New account**, and enter the following details in the **Add account** area.

    1. **Channel details**:
         - **Name**: Enter a name for the custom messaging account.
         - **Channel**: Select **Custom** from the list.
         - **Method**: Select **Azure bot framework** from the list, and then select **Next**.
    
    1. **Account details**:
         - **Microsoft app ID**: Enter the Microsoft app ID.
         -  **Client secret**: Enter the client secret value. <br>
         Select **Validate**. After your validation is successful, select **Next**.

    1. **Custom channel**: Select **Add** and enter the following information:
          - **Name**: Enter a name for the custom messaging channel.
          - **Channel**: Select a messaging channel from the list.
          Select **Add** to add the channel to the account. <br>
        You can repeat this step to add more channels to the same custom messaging account. <br>
        After you've added one or more channels to the account, select **Save and close**.
    4. **Callback information**: Copy the endpoint value in **Messaging endpoint URL**.
        Perform the following steps on the Azure portal:
        1. Open your Azure bot resource on the Azure portal in another tab or window.
        2. Go to **Settings** > **Configuration**.
        3. Paste the messaging endpoint URL in the **Messaging endpoint** field. If you're adding a Direct Line Speech channel, then be sure to select **Enable Streaming Endpoint**.
        5. Select **Apply** and close the Azure portal.
        6. Select **Save and close**. <br>
    You've now created a custom messaging account and added one or more custom channels to the account.

## Configure workstream and routing rules for the custom channel

1. In the site map, select **Workstreams** and [create a workstream](create-workstreams.md). Be sure to select **Messaging** for **Type** and **Custom** for **Channel**.
1. Select the workstream that you created for the custom channel, and on the page that appears, select **Set up Custom** and enter the following details:
   1. On the **Custom channel** page, select the account that you created.
   2. On the **Language** page, select the required language.
   3. On the **Behaviors** page, configure the following options:
      - [Custom automated messages](configure-automated-message.md)
      - [Post-conversation survey](configure-post-conversation-survey.md)
   4. On the **User features** page, set the toggle for **File attachments** to **On** and select the following checkboxes if you want to allow agents and customers to send and receive file attachments. More information: [Enable file attachments](enable-file-attachments.md)
      - Customers can send file attachments
      - Agents can send file attachments
   5. Verify the settings on the **Summary** page, and select **Finish**. The custom channel instance is configured.

1. [Configure routing rules](configure-work-classification.md).


#### Create a workstream in Omnichannel Administration

**To create a workstream for custom channel in Omnichannel Administration**

1. Sign in to Dynamics 365, and go to the Omnichannel Administration app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select **New** to create a new workstream.

4. Specify the values for the fields.

5. Select the **Custom** option for the **Channel** field.

6. Select **Save** to save the changes.

You've created a workstream for the custom channel. To learn more, see [Create workstreams](create-workstreams.md).

To configure other options in the workstream, see the following:

- [Skill-based routing](overview-skill-work-distribution.md)
- [Productivity tools](../app-profile-manager/productivity-tools.md)
- [Smart assist](../app-profile-manager/smart-assist.md)
- [Templates](/dynamics365/app-profile-manager/templates-overview)

#### Create a custom messaging account in Omnichannel Administration

After you create a workstream for a custom channel, you need to create a custom channel with the details of the **Microsoft app ID** and **Client secret** that you retrieved while registering your messaging channel in Azure Bot Service.

To create a custom channel, follow these steps:

1. Sign in to Omnichannel Administrator.

2. Select **Custom** under **Channels**.

3. Select **New** in the **Active Custom messaging account** view.

4. In the **New Custom messaging account** page, specify the values for the following fields:

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|
    | Account details |Name| Specify a name for the custom channel.| Contoso custom channel |
    | Account details |Microsoft app ID| Copy and paste the **Microsoft app ID** that you saved earlier from the Azure Bot Channel Registration page. <br> To learn more, see [Get registration password](/azure/bot-service/bot-service-quickstart-registration#get-registration-password). | cae1d83e-8b07-4fca-8072-c2eb3444vxyz |
    | Account details |Client secret| Copy and paste the **Client secret** that you saved earlier from the Azure Bot Channel Registration page.  <br> To learn more, see [Get registration password](/azure/bot-service/bot-service-quickstart-registration#get-registration-password).| |


5. Select **Validate app ID + secret**  to validate the **Microsoft app ID** and **Client secret** values. After the validation, a toast notification is displayed. Also, the **Last validated** field shows time and date. This ensures that bots are active and client secret refreshes are consumed. 

   :::image type="content" source="media/custom-channel-1.png" alt-text="Account details in custom channel.":::
   

6. Select **Save** to save the changes. After you save, in the **Callback information** section, the **Message endpoint (URL)** field is generated with a URL. Copy the URL from the field.

    > [!div class=mx-imgBorder]
    > ![Callback information for custom channel.](media/custom-channel-2.png "Callback information for custom channel")

7. Go to the **Azure Portal** > **Bot Channel Registration** page, paste the URL into the **Message endpoint** field, and save the changes.

8. In the **Channels** section, select **New Custom messaging channel**. The **New Custom messaging channel** page is displayed.

   After you create a **Custom messaging account**, you need to create a custom messaging channel, which is the actual channel from which Omnichannel for Customer Service agents will receive messages from the customer.

9. On the **New Custom messaging account** page, specify the values for the following fields:

    | Section | Field | Description | Example  value |
    |-------------|-------------------|---------------------------|--------------------------------------|  
    | Details | Name | Specify a name for the custom channel | Contoso channel |
    | Details | Custom Messaging Account | The **Custom messaging account** field is populated. However, you can change the value using the lookup. | Contoso custom channel |
    | Details | Channel ID | Select a channel from the list. The list might contain line-of-business (in-house) messaging or another messaging channel. | Telegram |
    | Work distribution | Work stream | Select a workstream from the lookup. | Contoso custom channel work stream |

    > [!Note]
    > A **Custom messaging account** can have multiple unique channel IDs. Don't add two or more same Channel IDs to a **Custom messaging account** because the Azure Bot Framework supports only one messaging account per App ID. For example, for **Contoso custom account**, you can't add two or more **Telegram** Channel IDs.

    :::image type="content" source="media/custom-channel-3.png" alt-text="General tab page for custom channels.":::

10. Optionally, on the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

11. Select **Save** to save the custom messaging channel.

12. Select the back button on the browser to go to the custom messaging account page. You can see that the custom messaging channel is added in the **Channels** section.

13. Select **Save** to save the configurations.

    :::image type="content" source="media/custom-channel-4.png" alt-text="Summary page for custom channel.":::


#### Modify settings for a specific custom channel

1. In the Omnichannel Administration app, go to **Custom** and select the custom channel you want to modify.

2. On the **General settings** tab, provide the following information:
    
    - **Language**: Select the preferred language for your custom channel.
    
    - **Work stream**: Select an existing workstream or create a new one.

    - **Enable file attachments for customers**: Set to **Yes** to allow customers to send file attachments to agents. Otherwise, set **No**.

    - **Enable file attachments for agents**: Set to **Yes** to allow agents to send file attachments to customers. When the agent sends an attachment, the app sends the blob storage URL to the channel. Otherwise, set **No**.
    
       To learn more about attachments, see [Enable file attachments](enable-file-attachments.md).
       
       To learn more about uploading media in Direct Line, see [Azure Bot Service documentation](/azure/bot-service/rest-api/bot-framework-rest-direct-line-3-0-send-activity?view=azure-bot-service-4.0&preserve-view=true).
       
       To learn more about uploading media in Telegram, see the [Telegram Bot API](https://core.telegram.org/bots/api#available-types).

3. On the **Automated messages** tab, [configure automated messages](configure-automated-message.md).

4. On the **Surveys** tab, [configure a post-conversation survey](configure-post-conversation-survey.md).

## Next steps

[Test your custom messaging channel](test-custom-channel-sample-html.md)
### See also

[Bring your own custom messaging channel using Direct Line](bring-your-own-channel.md)  
[Support for live chat and asynchronous channels](card-support-in-channels.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
