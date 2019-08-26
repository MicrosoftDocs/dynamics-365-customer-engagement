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

When scheduling work orders and other entities, you can match the required service territory to the resources in those territories.

Lets use work orders as an example.

When you assign a service account to a work order as required, the service territory of the account will auto populate on the work order, assuming the service account belongs to a service territory.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-territory-account-work-order.png)

Otherwise a service territory can be added manually on the work order form.

When you attempt to book a work order via the schedule assistant by selecting **Book** from the work order form or via the schedule board, the Service Territory will auto populate as a Filter, and only display related resources. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/territoryfilters.png)

and the resources displayed will be part of that territory. 

If needed, you can manually add multiple territories as filters, this will search for resources in either territory.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-territory-sa-multiple.png)

## Territories on the schedule board

Territories are also used on the schedule board to more effectively manage resources. It is common to create schedule board tabs specific to a single territory that is managed by a dispatcher.

From the schedule board, simply add one or more territories as filters, and the resources displayed will adjust accordingly. Then choose **Options > Save Current Filters as Default** to ensure the filters remain the next time you return to the schedule board tab.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-territory-sb-filter-all.png)

If you would like to filter requirements in the lower pane by the Territories, select the gear in the top right to access schedule board configurations and select **Apply Filter Territory**. In the image above, this filters the requirements in the lower panel to those in the "WA territory. Now both the resources and the requirements in the scheduel board tab all belong to the same territory.

## Configuration considerations

In **Resource Scheduling > Settings > Administration > Scheduling Parameters** there is a setting called **Auto Filter Service Territory** that will filter requirements on the schedule board tab based on the filtered territory by default. This corresponds with the example in the previous step.


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
  