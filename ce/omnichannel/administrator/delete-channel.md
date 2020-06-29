---
title: "Delete a channel or page to stop receiving messages on a channel in Omnichannel for Customer Service | MicrosoftDocs"
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

You can delete an instance of a configured channel or SMS number in scenarios such as when it isn't required, you don't want to receive messages on it, or the settings are corrupted.

## Delete a configured channel

1. Sign in to Omnichannel Administration.

2. Select a messaging channel such as Facebook in the left pane<!--Writing Style Guide-->.

3. On the page that appears, select the configured channel instance that you want to delete.

    > [!div class=mx-imgBorder]
    > ![Active Facebook Applications list](../media/active-facebook-applications.png "Active Facebook Applications list")

4. On the page toolbar, select **Delete**.

    > [!div class=mx-imgBorder]
    > ![Omnichannel page toolbar](../media/oc-toolbar.png "Omnichannel page toolbar")

5. In the **Confirm Deletion** message that appears, select **Delete**.

If you want to reconfigure your social channel or SMS number in Omnichannel for Customer Service, follow the channel-specific instructions.

## Delete a Facebook page

If you no longer want to receive messages on a  Facebook page that you've configured for your Facebook channel in Omnichannel for Customer Service, you can go to the page and delete it.

1. In Omnichannel Administration, in the left pane under **Channels**, select **Facebook**. 
1. Select the channel that contains the page you want to delete.
1. On the ***<Channel_name>* Facebook Application** page that appears, in the **Facebook Pages** area, select the check box for the page to be deleted.
1. Select **More Commands** to the right of the list, and then select **Delete Facebook Page**. 
<!--Edit assumes that the alternative you give below replaces all four steps of this procedure. If the alternative actually applies only to step 4, you can use the pattern:
4. Select **More Commands*** etc.
   or
   Open the Facebook page and select **Delete** etc.-->
Alternatively, you can open the Facebook page and select **Delete** on the page toolbar that appears.

### See also

[Channels in Omnichannel for Customer Service](channels.md)  
[Delete solutions](delete-solution.md)  