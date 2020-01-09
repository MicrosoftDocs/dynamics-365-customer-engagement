---
title: Share knowledge articles in the Omnichannel for Customer Service | MicrosoftDocs
description: Understand how you can share knowledge articles in the Omnichannel for Customer Service
author: anjgupta
ms.author: anjgup
manager: shujoshi
ms.date: 07/01/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Share knowledge articles in the Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

Enable knowledge article sharing in Omnichannel for Customer Service so customer queries can be resolved quickly. You can configure an external portal in the **Customer Service Hub** app in a way that your customer service agents can share knowledge article links with the customers from within the Omnichannel for Customer Service app.

Follow these steps to enable knowledge article sharing.

1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 

2. In the **Support Portal Connection** section, enter the following:  

    a. **Use an external portal**. Select **Yes** to enable the external portal and share the article as a link. </br>

    b. **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *http://\<support portal URL>/kb/{kbnum}* 
  
     The placeholder "{kbnum}" is replaced by an actual knowledge article number.  

3. Select **Save** to save the settings.

    > [!div class=mx-imgBorder]
    > ![Omnichannel knowledge management](../media/oc-km.png)

To know more about how to configure external portal in the **Customer Service Hub** app, see [Set up knowledge management (Customer Service Hub)](../../customer-service/set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management-customer-service-hub).

### See also

[Search and share knowledge articles](../agent/agent-usd/left-control-panel.md#search-for-and-share-knowledge-articles)
