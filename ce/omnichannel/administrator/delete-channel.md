---
title: "Delete channel/page to stop receiving messages on a channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Deactivate or delete a channel to turn off and stop receiving messages on the channel in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/25/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Delete a configured channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You can delete an instance of a configured channel or SMS number in scenarios, such as when it is not required, you don't want to receive messages on it, or the settings are corrupted.

## Delete a configured channel

1. Sign in to Omnichannel Administration.

2. Select a messaging channel such as Facebook in the left navigation pane.

3. On the page that appears, select the configured channel instance that you want to delete.

    > [!div class=mx-imgBorder]
    > ![Create a Facebook work stream](../media/active-facebook-applications.png "Active Facebook Applications list")

4. Select **Delete** on the page toolbar. The **Confirm Deletion** message appears.

5. Select **Delete**. The channel is removed.

    > [!div class=mx-imgBorder]
    > ![Create a Facebook work stream](../media/oc-toolbar.png "Omnichannel page toolbar")

If you want to reconfigure your social channel or SMS number in Omnichannel for Customer Service, follow the channel-specific instructions.

## Delete a Facebook page

If you no longer want to receive messages on a  Facebook page that you have configured for your Facebook channel in Omnichannel for Customer Service, you can go to the page, and delete it.

1. In Omnichannel Administration, select **Facebook** under **Channels** in the left navigation bar. The list of configured channels appears.
2. Select the channel that contains the page you want to delete.
3. On the ***<Channel_name>* Facebook Application** page that appears, in the **Facebook Pages** area select the check box against the page to be deleted.
4. Select **More Commands** to the right of the list, and select **Delete Facebook Page**. Alternatively, you can also open the Facebook page, and select **Delete** on the page toolbar that appears.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Delete solutions](delete-solution.md)  