---
title: "Monitor and manage system jobs for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d8a87798-4163-4785-9985-6fd2993abb85
caps.latest.revision: 24
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Monitor and manage system jobs
Several [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] features use system jobs to perform tasks automatically, including workflows, import, and duplicate detection, running independently or in the background.  
  
 You can monitor them to ensure that they run smoothly or have completed successfully.  
  
## Monitoring system jobs  
 If there is a problem with a system job, you can cancel, postpone, pause, or resume it.  
  
- **Canceling system jobs**  
  
     You cannot resume a canceled system job.  
  
- **Postponing completion of system jobs**  
  
     Postponing an active system job stops any current and subsequent actions. You can specify a later time when you want the system job to restart.  
  
- **Pausing system jobs**  
  
     You can resume a paused system job.  
  
- **Resuming paused system jobs**  
  
     Resuming restarts a system job that was paused.  
  
    > [!TIP]
    >  1.  If a system job fails, you can view the details about what steps failed and what the problems may have been.  First, open the system job record.  To display details about system job failures, move your pointer over the warning symbols.  
    > 2.  To view system job failures in a format that you can print or copy and paste, click the **Print** button.  
  
> [!NOTE]
>  You cannot make changes to the status of a system job that has been completed or canceled.