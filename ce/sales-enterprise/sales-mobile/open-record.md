---
title: Open a record in the Dynamics 365 Sales mobile app
description: Instructions to open a record in the Dynamics 365 Sales mobile app
ms.date: 11/30/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Manage records or regarding entities

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Records or regarding entities are accessible through the Home or Meetings page.   
- On the **home** page, go to **Recent records** section.   
- On The **Meetings** page, go to **Regarding** section.   

> [!NOTE]
> You'll be able to set the regarding record only if server-side synchronization has been enabled in your environment. Contact your administrator to enable it.

You can do the following actions on records or regarding entities:   
- [View details](#view-details)   
- [Edit the entities](#edit-the-entities)   
- [Change regarding entity in meetings](#change-regarding-entity-in-meetings)   
- [Add regarding entity to meetings](#add-regarding-entity-to-meetings)

## View details

To view more details about the record or regarding entities, tap the entity and the record is opened in the lightweight view. The details such as timeline activities and relevant cards are displayed along with related entities cards. Also, related entities are displayed if any related entities are attached to the regarding entity. You can swipe to view the related entities.   
- On the **Home** page, tap the record to view the details.     
- On the **Meetings** page, tap **Open (record type)** to view the details.

## Edit the entities

To edit records on the Home page, open the record and then tap **Edit** on the top-right corner of the entity page. The record opens in the entity form of the Sales Hub app to edit.

To quickly edit the basic information of the regarding entity in the **Meetings** page, tap **More options** (![Options button](media/sm-options-button.png "Options button")) and then tap **Quick edit**. Enter the required information and then tap **Save**.   
    >[!div class="mx-imgBorder"]
    >![Select quick edit option](media/sm-quick-edit-regarding-entity.png "Select quick edit option")    
Also, you can open the entity and then tap **Edit** on the top-right corner of the entity page. The record opens in the entity form of the Sales Hub app to edit.    

## Change regarding entity in meetings   

You can update the regarding entity when it no longer is relevant or there are changes to the meeting. To change the regarding entity, follow these steps:   
1. Tap **More options** (![Options button](media/sm-options-button.png "Options button")) and then tap **Change connected record**.    
    >[!div class="mx-imgBorder"]
    >![Select change connected record option](media/sm-select-change-connected-record.png "Select change connected record option")        
2. On the **Regarding** page, either select a recent record or tap **Search** to look for the record you want.    
    >[!div class="mx-imgBorder"]
    >![Search for a record to connect](media/sm-regarding-record.png "Search for a record to connect")    
3. After selecting a record, tap **Save**.    
    >[!div class="mx-imgBorder"]
    >![Select a record to connect](media/sm-select-regarding-record.png "Select a record to connect")    
The connected record details are displayed in the **Regarding** section.

## Add regarding entity to meetings
You can add a regarding entity to a meeting when no regarding entity is attached to it. When you add the regarding entity, its corresponding related entities are also added to the meeting.  

>[!NOTE]  
>Once you add a regarding entity, you cannot delete it. However, you can update the entity if you find the added entity is inappropriate.   

1. On the meeting details page, tap **Set regarding**.   
    >[!div class="mx-imgBorder"]
    >![Connect a record to a meeting](media/sm-meeting-details-no-record.png "Connect a record to a meeting")   
2. On the **Regarding** page, either select a recent record or tap **Search** to look for the record you want.   
    >[!div class="mx-imgBorder"]
    >![Search for a record to connect](media/sm-regarding-record.png "Search for a record to connect")   
3. After selecting a record, tap **Save**.   
    >[!div class="mx-imgBorder"]
    >![Select a record to connect](media/sm-select-regarding-record.png "Select a record to connect")    
The connected record details are displayed in the **Regarding** section.    
    
> [!NOTE]
> - The fields that you see on the compact form are defined in the quick view form of the entity.
> - The lightweight view doesn't include all attributes of the entity.
> - This is a lightweight form that contains any attributes defined in the first form on quick view form set order. More information: [Set the form order](https://docs.microsoft.com/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

### See also

[Learn the basics](sales-mobile/learn-basics-mobile-app.md)   
[View meetings](sales-mobile/view-agenda.md)