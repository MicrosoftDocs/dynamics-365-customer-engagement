---
title: Manage records in the Dynamics 365 Sales mobile app
description: Learn to view and edit records in the Dynamics 365 Sales mobile app.
ms.date: 11/30/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Manage records

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Records and regarding entities can be accessed from the home page or the Meetings page.

- On the home page, go to the **Recent records** section.   
- On the Meetings page, go to the **Regarding** section.   

> [!NOTE]
> You'll be able to set the regarding record only if server-side synchronization has been enabled in your environment. Contact your administrator to enable it.

You can [view details](#view-details) and [edit the entities](#edit-the-entities) on records on the home and Meetings pages. Additionally, you can [change a regarding entity](#change-regarding-entity) and [add a regarding entity](#add-regarding-entity) on the Meetings page.

## View details

You can view the details of records in the following ways: 

**On the home page**    

The home page displays a list of records that you have recently accessed. These records include opportunities, leads, contacts, quotes, accounts, and notes. When you tap the record, the record opens in a lightweight form. This form provides the basic details, including [related notes and reminders](#notes-and-reminders). 

**On the Meetings page**     

The Meeting details page displays the regarding entity that is related to the meeting.<!-- Edit note: Is it correct that there is only one entity. --> Also, the notes and insights that are displayed in the meeting are related to the displayed regarding entity. Tap **Open *record type*** to view the details in the lightweight form. The details include basic information about the entity, [related notes, and reminders](#notes-and-reminders). 

>[!NOTE]
>To learn more about notes, see [Manage notes](view-edit-add-note.md).

## Edit records and entities<!-- Edit note: How about "Edit records and entities" since both are mentioned -->

Follow these steps to edit records and entities in the Dynamics 365 Sales mobile app.

- To edit records on the home page, open the record. In the upper-right corner of the quick view form, tap **Edit**. Edit the details in the Edit form and tap **Save**. To open the record in the Sales Hub app, tap **Open *record type***.<!-- Edit note: Revised to better match the screenshot and to put the directional info up front. -->

    >[!div class="mx-imgBorder"]
    >![Quick view form opened from the home page](media/sm-homepage-view-details-lead.png "Quick view form opened from the home page")
    
- To quickly edit the basic information about the regarding entity on the **Meetings** page, tap the three dots, **More options** (![Options button](media/sm-options-button.png "Options button")), and then tap **Quick edit**. The record's Edit form opens. Enter or update the required information, and then tap **Save**.<!-- Edit note: Should "record" be "entity" here. -->

    >[!div class="mx-imgBorder"]
    >![Tap quick edit option](media/sm-quick-edit-regarding-entity.png "Tap quick edit option")    

    To edit the whole record, tap **Open *record type***. The record opens in the Sales Hub app for editing.<!-- Edit note: Should "record" be "entity" here. -->   

<a name='change-regarding-entity'></a>
## Change regarding entity in meetings

You can update the regarding entity when it is no longer relevant or there are changes to the meeting. To change the regarding entity, follow these steps:

1. Tap the three dots, **More options** (![Options button](media/sm-options-button.png "Options button")), and then tap **Change connected record**.

    >[!div class="mx-imgBorder"]
    >![Select change connected record option](media/sm-select-change-connected-record.png "Select change connected record option")
    
2. On the Regarding page, either select a recent record or tap **Search** to look for the record you want.

    >[!div class="mx-imgBorder"]
    >![Find a record to connect](media/sm-regarding-record.png "Find for a record to connect")
    
3. After selecting a record, tap **Save**.

    >[!div class="mx-imgBorder"]
    >![Select and save a record to connect](media/sm-select-regarding-record.png "Select and save a record to connect")
    
The connected record details are displayed in the Regarding section.

<a name='add-regarding-entity'></a>
## Add regarding entity in meetings

You can add a regarding entity to a meeting when no regarding entity is attached to it. When you add the regarding entity, its corresponding related entities are also added to the meeting.  

>[!NOTE]  
>Once you add a regarding entity, you cannot delete it. However, you can update the entity if you find that the added entity is inappropriate.   

1. On the meeting details page, tap **Set regarding**.

    >[!div class="mx-imgBorder"]
    >![Connect a record to a meeting](media/sm-meeting-details-no-record.png "Connect a record to a meeting")
    
2. On the **Regarding** page, either select a recent record or tap **Search** to look for the record you want.

    >[!div class="mx-imgBorder"]
    >![Find a record to connect](media/sm-regarding-record.png "Find for a record to connect")
    
3. After selecting a record, tap **Save**.

    >[!div class="mx-imgBorder"]
    >![Select and save a record to connect](media/sm-select-regarding-record.png "Select and save a record to connect")
    
The connected record details are displayed in the Regarding section. 

> [!NOTE]
> - The fields that you see on the compact form are defined in the quick view form of the entity.
> - The lightweight view doesn't include all attributes of the entity.
> - This is a lightweight form that contains any attributes defined in the first form on quick view form set order. More information: [Set the form order](https://docs.microsoft.com/powerapps/maker/model-driven-apps/control-access-forms#set-the-form-order)

## Notes and reminders

**Notes**

Notes displayed in the **Notes** section are related to the regarding entity that is associated with the meeting. You can add, edit, and delete notes. More information: [Manage notes](sales-mobile/view-edit-add-note.md)<!-- Edit note: Broken link. -->

**Reminders**

You can see the reminders through insight cards based on the regarding entity that is associated with the meeting. By tapping the three dots, **More options** (![Options button](media/sm-options-button.png "Options button")), on the card, you can take actions such as dismiss, snooze, and like or dislike the card. The cards are retrieved from your Dynamics 365 Sales organization for the selected regarding entity.

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

To learn more about insight cards, go to [Insight cards reference](https://docs.microsoft.com/dynamics365/ai/sales/action-cards-reference).  

## See also

[Learn the basics](learn-basics-mobile-app.md)   
[View meetings](view-agenda.md)
