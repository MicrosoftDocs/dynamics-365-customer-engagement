---
title: "Travel outside working hours | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Allow travel time outside of working hours with Resource Scheduling Optimization (RSO)



// https://msit.microsoftstream.com/video/e34ba1ff-0400-a936-9bdd-f1eaab46c013?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-before.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-after.png)




## Prerequisites
Universal Resource Scheduling v3.x+ (Field Service v8.x+)
> [!Note]
>



## Edit RSO constraints

Go to Resource Scheduling Optimization app > Optimization Goals > select or create an Optimization Goal

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-constraint.png)

## Enable Resource for scheduling outside working hours
Go to Resources

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-resource.png)

**Schedule outside working hours**: choose if RSO can schedule travel time before working hours, after working hours, or both. If you enter either or both values: _Allow Travel Time Before Work Hours_, _Allow Travel Time Before Work Hours_ you must enter a Travel limit. 

**Travel limit (in minutes)**: dictates how many minutes before or after work a resource is permitted to travel. 

## Run RSO


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-after2.png)

## Improve utilization 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/rso-travel-outside-utilization.png)

## Configuration considerations

// use Q&A of video if necessary

- you cannot have different travel limits before and after working hours. As an example, you cannot configure a 30 minute travel limit before work and a 60 minute travel limit after work.

### Schedule within working hours constraint vs travel outside working hours

## Additional Notes


end time will be within working hours