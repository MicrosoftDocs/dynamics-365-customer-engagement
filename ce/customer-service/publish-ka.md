---
title: Publish knowledge articles 
description: Learn how to schedule and publish knowledge articles. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 01/23/2023
ms.custom: bap-template
---

# Publish knowledge articles

After the content in the article is complete and reviewed, you can publish the article to the portal to make it available to your customers. You can publish the article immediately or schedule it for a later time.

> [!IMPORTANT]
>  If your organization is using a portal to publish the knowledge articles, your customizer can write a plug-in that can pick the published articles and post on your portal, and also report the article views back.

## Prerequisites

Ensure that you have the Publish and Update permissions on the Knowledge Article record type. These permissions are added by default to the roles of knowledge manager, customer service manager, customer service representative, or system administrator. You will also need the Publish permission on the Knowledge Article record type, if you want to change the state of a published article.

## Publish an article
  
1.  In the Customer Service Hub, go to **Service** > **Knowledge Articles**.  
  
2.  Open a knowledge article that’s in the **Approved** state.  
  
1.  To make it easy to find knowledge articles related to specific products, associate the knowledge article with a product.  
  
    1.  On the command bar, select **More** > **Relate Product**.  
  
    2.  In the **Select Product to Associate with** field, select the **Lookup** button, select a product this article is about, and then select **Associate**.  
  
         The associated article appears in the **Related Products** list in the **Related Information** section of the **Summary** tab.  
  
1.  On the Business process bar, select the **Publish** stage.  
  
1.  In the **Set Product Associations** field, select **Mark as Complete**.  
  
1.  If you want to schedule the article to publish on a later date, on the **Summary** tab, in the **Publish On** field, select a date and time to publish the article.  

1.  Select **Finish**. The Publish dialog is displayed.

  > [!NOTE]
  > The Publish dialog appears only for the default business process flows where the final stage is **Publish**. To configure the Publish dialog for other customized stages, see [Process events and event handler methods](/powerapps/developer/model-driven-apps/clientapi/reference/formcontext-data-process#process-events-and-event-handler-methods).

-   In the **Publish** field, select whether you want to publish the knowledge article now or in the future. To publish the article in the future, in the **Publish On** field, select a date and time.  
  
-   In the **Published Status** field, select what status the article should be in after it is published. By default, **Published** is selected.  
  
-   In the **Expiration Date** field, select a date and time when you want the published article to expire. Expired articles are no longer available in searches.  
  
-   If you’ve set an expiration date, in the **Expiration Status** field, select the status the knowledge article should be set to after it expires.  
  
-   To publish all approved related translated articles with the article, in the **Publish Approved related translations with Article** field, select **Yes**.  
  
-   Select **Publish**. 
       
    :::image type="content" source="media/ka-publish.png" alt-text="Schedule or publish an article":::
    
> [!NOTE]
> In the knowledge article for interactive experience form, if there is an active customization layer over the **msdynce_KnowledgeManagementFeatures** layer, you won't be able to view the quick form publish dialog. You must delete the active customization layer to view the quick form publish dialog. More information: [Removed an unmanaged layer](/powerapps/maker/data-platform/solution-layers#remove-an-unmanaged-layer).

## Update published knowledge articles  

When a knowledge article is in the Published (or Scheduled) state, only those users who have the Publish privilege can update it.  
  
1.  In the Customer Service Hub site map, go to **Service** > **Knowledge Articles**.  
  
2.  Select the published article you want to edit.  
  
3.  On the command bar, select **Update**.  
  
4.  Update the article based on the feedback.  
  
If the article has information that complements an existing knowledge article, associate the existing article with the current knowledge article.  
  
1.  In the knowledge article, on the command bar, select **More** > **Relate Article**.  
  
2.  In the **Select Article to Associate** field, select the **Lookup** button, select an existing article, and then select **Associate**.  
  
     The associated article appears in the **Related Articles** list in the **Related Information** section of the **Summary** tab.