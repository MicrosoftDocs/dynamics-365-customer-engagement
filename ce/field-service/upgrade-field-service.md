---
title: "Upgrade Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 12/3/2019
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

# Upgrade Field Service

Microsoft releases updates to the Dynamics 365 Field Service app and related solutions to add new capabilities, enhance the performance and usability of existing features, and fix bugs. In this article we will provide details on upgrading Field Service including the related mobile app and Resource Scheduling solutions.

## Field Service

### When are Field Service updates released?
Multiple Field Service updates are released every year.

**Minor updates** are released each month and include minor new features, enhancements, and bug fixes.

**Major updates** are released twice each year: April and October; and include major new features, as well as minor new features, enhancements, and bug fixes.

Though it is rare, occasionally a critical "hot fix" will be released outside of the monthly minor updates or the bi-yearly major updates.

The details of upcoming major and minor releases are listed in the [upcoming release plans](https://docs.microsoft.com/dynamics365/release-plans/) once they are committed. April release plans will include 


auto update motion 
how it works, whats the cadence, 
same or different from platform
lack of disruption

Advise customers about the FS upgrade cadence and difference between FS updates and Core updates. Also to provide steps to check for available upgrades for FS as a first step.

see in release planner

monthly minor updates
bi-yearly major updates- preview 2 months in advance

autoupdate is minor release eventually major

field service package includes multiple solutions including URS + patches

look at anchor solution to know what solution you have, or look at trial

some solutions are conditionally upon woodford 

delete anchor and retry maybe? talk to jorn

### How do I upgrade my environment?

For FS v8, our plan is that orgs on v8 UR13 (FS v8.8.7.47) or higher will begin receiving automatic updates, correct? Can we add a note to the FS documentation about auto-update?

auto update or admin center

minimum of UR12 will get autoupdates **8.8.6.x**

UR 11


https://dynamics.wiki/index.php/Customer_Care_Apps_Release_Calendar(FS,CS,KM)


auto update begins week after you can manually upgrade
- All new Dynamics 365 Field Service environments will install the latest generally available Field Service solution. If you would like to set up a trial of the latest Field Service version, create a trial through [https://trials.dynamics.com](https://trials.dynamics.com).

For existing environments, when a new upgrade is available, you can upgrade your solution in **Admin Center** > **Dynamics 365**, as seen in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of the admin center upgrade path for Field Service](./media/admin-upgrade-to-latest-admin-center.png)

### Best practices

https://aka.ms/fsuciupgrade

if you have PSA you should update both FS and PSA at same time, epsecially for major updates


unsupported modifying web resources can have functional issues after upgrade but will not block upgrade

to understand if you edited a web resource, use health hub

before upgrading prod org, make copy of prod and make update there 


## Mobile

Installing Field Service Mobile from the Windows Store can allow for automatic upgrades of new versions.

[Upgrade mobile project](mobile-upgrade-project.md)

update mobile app FIeld Service Mobile 

## Resource Scheduling

Resource scheduling is updated in the same cadence as Field Service

FS updates will update URS, 



Step 1:

Before upgrade we would suggest customers to make sure they dont customize any internal only web resources/java script files, so that they dont get skipped during the upgrade 

Easy way to check this is by running the Resource Scheduling Service Health Diagnostics tool and make sure there are no flags when they assess their upgrade readiness 

Here is where users can find this tool 
they should remove the customizations out of the web resource and then run the upgrade. Not all customizede web resources will be flagged by this tool, only the ones that could have the critical impac 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-rs-health-diagnostics.png)

Step 2:

UFX queries


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-ufx-queries.png)

## Resource scheduling Optimization

Go to admin center > Instances tab > solution

Select Upgrade to new version to apply a new update if one is available.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-rso-upgrade-available.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-rso-applications-manage.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/upgrade-rso-upgrade-to-new-version.png)

## Prerequisites
> [!Note]
>



## Configuration considerations


## Additional Notes
- 7.x end of life

### Common issues
- Field Service upgrade failure/DB out of sync and resolution steps that the customer can try on their own.
- Solution installation failed / Update Installation Failed
- Field Service database version is out of sync
-  upgrade did not complete, 
if auto update fails, there is retry






### See also
[Field Service version history](version-history.md)

[Install Field Service (web + mobile)](install-field-service.md)

[Important Notes for Field Service and Project Service Automation after upgrade of Dynamics 365 Organizations to version 9.0](https://community.dynamics.com/365/b/365teamblog/posts/important-notes-for-field-service-and-project-service-automation-after-upgrade-of-dynamics-365-organizations-to-version-9-0)

[Announcing end-of-life for Field Service (online) legacy versions by February, 2020](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/17/announcing-end-of-life-for-field-service-online-legacy-versions-by-february-2020/)