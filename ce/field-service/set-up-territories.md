---
title: "Territories | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/22/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: FieldServiceDave
ms.assetid: 5b22bdbc-4c52-4889-bf29-df0023d504f6
caps.latest.revision: 17
ms.author: Hollycha
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Territories for accounts, work orders, and scheduling

Territories help you divide your business into geographical regions for work order management, scheduling, and reporting. You can group your customers, work orders, and resources based on city, state, county, postal code, or a custom territory such as "West region."

By using territories with work orders and resources, you can ensure dispatchers only schedule work orders to field technicians (resources) with a matching territory. In other words, territories serve as a filter on the schedule board, schedule assistant, and resource scheduling optimization.

Territories are also important for reporting because many organizations want to measure first time fix rate, work order count by type, and work order invoice revenue **by territory**.

Configuring territories in the Field Service solution includes:

1. Creating your territories
2. Associating territories to resources
3. Adding accounts to territories
4. Using territories during work order scheduling
5. Using territories on the schedule board
 
   
## Create a territory 

Create all of your territories as master data in Field Service Settings. Sometimes this is done via importing an Excel sheet.
  
1.  From the main menu, click **Field Services** > **Administration**, and then choose **Territories**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/territories.png)

2.  On the **All Territories** screen, click **+New** in the upper left corner.  
  
3.  Fill in your information: 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/newterritory.png)
  
  - **Name**: Enter the geographical name for the territory, such as the name of a city, country/region, or a state.  
  
  - **Manager**: Enter the name of the user who manages this territory. This person typically assigns leads to salespeople.  
  
  - **Description**: Enter any details that you'd like to include for this territory,   
  
4.  **Save & Close**.  

 
## Assign resources to territories

Field technicians, equipment, and facilities, represented in the system as Bookable Resources, can belong to one or more territories to define the geographic territories they work in.
  
1. Go to Resources in the main menu and select the resource you want to add to a territory.  
  
2. From the resource form go to **Related** > **Resource Territories**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/resourceterritory.png)

3.  Then select **+ Add New Resource Territory**

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/newresourceterritory.png)


4. Populate the Territory, Resource, and Name (optional).  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/multipleterritoriesonresource.png)


> [!Note]
> Resources can be a part of multiple territories, but accounts and work orders can only belong to one. 
 
## Add accounts to territories

Next, mark each account as part of a service territory. 

This is done in the **Service Territory** lookup field on the Field Service tab of the Account form, which is exposed when the Field Service app is installed in your Dynamics 365 environment. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/accountterritory.png)
 


> [!Note]
> An account can only be part of one service territory.
 

## Territories for scheduling

If a service territory is assigned to a service account record, and a work order is generated for that service account, then the work order will inherit the service territory from the service account. 

When you are scheduling a work order using the scheduling assistant, the suggested available resources can be filtered based on the resources that are assigned to the same territory as the work order. 

By assigning a Territory to a Work Order, either manually or automatically through a workflow or mapping, the Scheduling Engine will use the Territory to find a resource in the matching territory.  This will ensure resources stay within their assigned territories.  To ensure the Territory will be used, enable the filter by default in the Scheduling Parameter. This setting is found in the Universal Resource Scheduling App, Administration.   Verify Auto Filter Service Territory set to Yes.
 
 
When a Work Order is Booked, the Service Territory will be auto populated in the Filter. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/territoryfilters.png)

## Territories on the schedule board


Using territories also helps dispatchers manage the schedules more efficiently when managing the schedule board. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/scheduleboard.png)

Territories can also be leveraged to create a segmented Schedule Board.  By simply using the Territory filter and saving the filters, organizations can have focused territory boards.  

## Configuration considerations

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/schedulingparameter.png)

## Additional notes

- postal codes - works with account and work order
- other uses for territories, Sometimes, they're an overlap of functional area and geography. 
- workflows that add and remove resources to territories by day of week
- territories are not hierarchical 
- territories for non work order scenarios- traveling sales person
- You can't allocate the same user (not resource entity, but user entity) to multiple territories. If you need to assign a user to a large area (more than one existing territory), create a new territory that includes the existing territories, and then assign the user to that new territory.  
- crews?
  