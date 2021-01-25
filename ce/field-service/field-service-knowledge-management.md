---
title: "Knowledge management in Field Service | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 02/01/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Knowledge management in Field Service


// https://msit.microsoftstream.com/video/595ba1ff-0400-9887-23d4-f1eb5a0959f3?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d

features:
- same knowledge management as customer service. dont need customer service its included with FS but if you have customer service you can use the same knowledge articles for both apps.
- available on mobile offline
- link to cases, work orders, incidents, products and assets

business value:
- improve first time fix rate
- guide technicians through procedures and help

## Prerequisites
> [!Note]
>




## Create a knowledge article

First create a knowledge article. 

From the Field Service app go to Settings > Knowledge articles. 

Create a knowledge article and add text, pictures, and videos as needed.

Then save and publish the article.

For the following topics for details:

- [Create and manage knowledge articles](https://docs.microsoft.com/dynamics365/customer-service/customer-service-hub-user-guide-knowledge-article)

- [Set up a search provider](https://docs.microsoft.com/dynamics365/customer-service/set-up-search-providers)


## Associate knowledge article to cases, customer assets, incident types, products


### Incident type


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/knowledge-article-associate-incident-type.jpg)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/knowledge-article-associate-incident-type2.jpg)

### Customer asset 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/knowledge-article-associate-asset.jpg)


if work order is associated to any of those records the knowledge gets linked to the work order

## Create a work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/knowledge-article-associate-work-order-linked.jpg)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/knowledge-article-associate-work-order-read.jpg)




## View work order and knowledge articles on the mobile app

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/mobile-2020-knowledge-mgmt.png)

- available offline (currently without images)

## Configuration considerations

- can unlink article



## Additional Notes

- if a case has knowledge articles realted to it, and a work order is created from the case, are the article auto associated to work order?








