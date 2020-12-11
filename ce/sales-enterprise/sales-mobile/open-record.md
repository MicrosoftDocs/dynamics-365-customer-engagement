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

# Manage records

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Records or regarding entities are accessible through the Home or Meetings page.   
- On the **home** page, go to **Recent records** section.   
- On The **Meetings** page, go to **Regarding** section.   

> [!NOTE]
> You'll be able to set the regarding record only if server-side synchronization has been enabled in your environment. Contact your administrator to enable it.

You can [view details](#view-details) and [edit the entities](#edit-the-entities) on records in the **Home** and **Meetings** pages. Additionally, you can [change regarding entity](#change-regarding-entity) and [add regarding entity](#add-regarding-entity) on regarding entity in the **Meetings** page.

## View details

You can view the details of records in the following ways: 

**On the Home page**    

The **Home** page displays a list of recent records that are accessed by you. These records consist of opportunities, leads, contacts, quotes, accounts, and notes. When you tap the record, the record opens in a lightweight form, which provides the basic details including [related notes and reminders](#notes-and-reminders). 

**On the Meetings page**     

The **Meeting** details page displays the regarding entity that is related to the meeting. Also, the notes and insights that are displayed in the meeting are related to the displayed regarding entity. Tap **Open *record type*** to view the details in the lightweight form. The details include basic information of the entity, [related notes, and reminders](#notes-and-reminders). 

>[!NOTE]
>To learn more on notes, see [Manage notes](view-edit-add-note.md).

## Edit the entities

- To edit records on the **Home** page, open the record and then tap **Edit** on the top-right corner of the entity page. The record opens in the quick edit form, edit the details and tap **Save**. Further, to open the record in the entity form, tap **Open *record type*** and the record opens in the Sales Hub app to edit.

    >[!div class="mx-imgBorder"]
    >![Quick view details through home page](media/sm-homepage-view-details-lead.png "Quick view details through home page")

- To quickly edit the basic information of the regarding entity in the **Meetings** page, tap **More options** (![Options button](media/sm-options-button.png "Options button")) and then tap **Quick edit**. The record opens in the quick edit form, enter the required information and then tap **Save**.    
    
    >[!div class="mx-imgBorder"]
    >![Select quick edit option](media/sm-quick-edit-regarding-entity.png "Select quick edit option")    

    To edit the whole record, tap **Open *record type*** and the record opens in the Sales Hub app to edit.     

<a name='change-regarding-entity'></a>
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

<a name='add-regarding-entity'></a>
## Add regarding entity in meetings
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
> - This is a lightweight form that contains any attributes defined in the first form on quick view form set order. More information: [Set the form order](https://docs.microsoft.com/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order).

## Notes and Reminders

**Notes**

Notes displayed under the **Notes** section are related the regarding entity that is associated with the meeting. You can add, edit, and delete notes. More information: [Manage notes](sales-mobile/view-edit-add-note.md).

**Reminders**

You can see the reminders through insight cards based on the regarding entity that is associated with the meeting. You can do actions such as dismiss, snooze, and like or dislike the card by tapping **More options** (![Options button](media/sm-options-button.png "Options button")) on the card. The cards are retrieved from your Dynamics 365 Sales organization for the selected regarding entity.       
The following reminder insight cards are supported:    
<table>
<tr>
<td>{activity} due today</td><td>Buying intent detected in email</td><td>Close date coming soon</td>
</tr>
<tr>
<td>Competitor mentioned</td><td>Email opened</td><td>Email reminder</td>
</tr>
<tr>
<td>File requested</td><td>Issue detected</td><td>Meeting requested</td>
</tr>
<tr>
<td>Missed (opportunity) closed date</td><td>Missed email</td><td>No activity with {record type}</td>
</tr>
<tr>
<td>Opportunity at risk (phrase detection)</td><td>Opportunity at risk (sentiment detection)</td><td>Suggested stakeholder</td>
</tr> 
<tr>
<td></td><td></td><td></td>
</tr>
</table>   

To know more about the insight cards, see [Insight cards reference](https://docs.microsoft.com/dynamics365/ai/sales/action-cards-reference)  

### See also

[Learn the basics](learn-basics-mobile-app.md)   
[View meetings](view-agenda.md)