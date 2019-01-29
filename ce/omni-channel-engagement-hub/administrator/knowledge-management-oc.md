---
title: Share knowledge articles in the Omni-channel Engagement Hub | MicrosoftDocs
description: Understand how you can share knowledge articles in the Omni-channel Engagement Hub
keywords: Omni-channel Engagement Hub; share knowledge articles
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 03e2226e-a947-4b41-8b19-cad79bf59ce4
ms.custom: 
---

# Share knowledge articles in the Omni-channel Engagement Hub

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

Knowledge articles can address any number of issues your customers encounter while using your organization's product or services. Types of knowledge articles can include solutions to common issues, product or feature documentation, answers to frequently asked questions (FAQs), product briefs, and more.

As a customer service agent, you can share knowledge articles with your customers in the Omni-channel Engagement Hub. To enable sharing of knowledge articles, the admin can configure the external portal in the **Support Portal Connection** section of the **Embedded Knowledge Search**. Admins can set up the external portal control in **Service Management** in the **Customer Service Hub** app.

To know more about how to configure external portal in the **Customer Service Hub** app, see [Set up knowledge management (Customer Service Hub)](../../customer-service/set-up-knowledge-management-embedded-knowledge-search.md#set-up-knowledge-management-customer-service-hub).

Follow these steps to enable knowledge article sharing using an external portal.

1. In the Customer Service Hub sitemap, go to **Service Management** and select **Knowledge Base Management** > **Embedded Knowledge Search**. 

2. In the **Support Portal Connection** section, enter the following:  

    a. **Use an external portal**. Select **Yes** to enable the external portal and share the article as a link. </br>

    b. **URL Format**. Type the portal URL that will be used to create external (public-facing) portal links for knowledge articles, which the service agents can share with the customers. The external URL is created in the following format: 
        </br> </br> *http://\<support portal URL>/kb/{kbnum}* 
  
     The placeholder "{kbnum}" is replaced by an actual knowledge article number.  

3. Select **Save** to save the settings.

    > [!div class=mx-imgBorder]
    > ![Omni-channel knowledge management](../media/oc-km.png)


### See also

[Use embedded knowledge search to set up knowledge management](../../customer-service/set-up-knowledge-management-embedded-knowledge-search.md)

[Search for and share knowledge articles](../agent/agent-usd/left-control-panel.md#search-for-and-share-knowledge-articles)