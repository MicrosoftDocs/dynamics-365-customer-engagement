---
title: Share knowledge articles in the Omni-channel Engagement Hub | MicrosoftDocs
description: Understand how you can share knowledge articles in the Omni-channel Engagement Hub
keywords: Omni-channel Engagement Hub; share knowledge articles
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 03e2226e-a947-4b41-8b19-cad79bf59ce4
ms.custom: 
---

# Share knowledge articles in the Omni-channel Engagement Hub

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Enable knowledge article sharing in the Omni-channel Engagement Hub so that customer queries can be resolved quickly. You can configure an external portal in the **Customer Service Hub** app, so that your customer service agents can share knowledge article links with the customers from within the Omni-channel Engagement Hub app.

Follow these steps to enable knowledge article sharing.

1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 

2. In the **Support Portal Connection** section, enter the following:  

    a. **Use an external portal**. Select **Yes** to enable the external portal and share the article as a link. </br>

    b. **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *http://\<support portal URL>/kb/{kbnum}* 
  
     The placeholder "{kbnum}" is replaced by an actual knowledge article number.  

3. Select **Save** to save the settings.

    > [!div class=mx-imgBorder]
    > ![Omni-channel knowledge management](../media/oc-km.png)

To know more about how to configure external portal in the **Customer Service Hub** app, see [Set up knowledge management (Customer Service Hub)](../../customer-service/set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management-customer-service-hub).

### See also

[Search and share knowledge articles](../agent/agent-usd/left-control-panel.md#search-for-and-share-knowledge-articles)
