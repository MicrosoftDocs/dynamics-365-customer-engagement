---
title: "Delete a channel or page to stop receiving messages on a channel in Omnichannel for Customer Service | MicrosoftDocs"
description: "Deactivate or delete a channel to turn off and stop receiving messages on the channel in Omnichannel for Customer Service."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 06/30/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---
# Delete a configured channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can delete an instance of a configured channel or SMS number in scenarios such as when it isn't required, you don't want to receive messages on it, or the settings are corrupted.

## Delete a configured channel

1. Sign in to Omnichannel Administration.

2. Select a messaging channel such as Facebook in the left pane.

3. On the page that appears, select the configured channel instance that you want to delete.

    > [!div class=mx-imgBorder]
    > ![Active Facebook Applications list](media/active-facebook-applications.png "Active Facebook Applications list")

4. On the page toolbar, select **Delete**.

    > [!div class=mx-imgBorder]
    > ![Omnichannel page toolbar](media/oc-toolbar.png "Omnichannel page toolbar")

5. In the **Confirm Deletion** message that appears, select **Delete**.

If you want to reconfigure your social channel or SMS number in Omnichannel for Customer Service, follow the channel-specific instructions.

## Delete a Facebook page

If you no longer want to receive messages on a Facebook page that you've configured for your Facebook channel in Omnichannel for Customer Service, you can go to the page and delete it.

1. In Omnichannel Administration, in the left pane under **Channels**, select **Facebook**.
2. Select the channel that contains the page you want to delete. The ***<Channel_name>* Facebook Application** page appears.
3. In the **Facebook Pages** area, do one of the following:
   - Use **More Commands** to the right of the list to delete the required Facebook page.
   - Select the required Facebook page, and then select **Delete** on the page that appears.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Delete solutions](delete-solution.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]