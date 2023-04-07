---
title: "Overview of the security roles for app profile manager | MicrosoftDocs"
description: "Overview of the security roles for app profile manager."
author: neeranelli
ms.author: nenellim
ms.date: 06/09/2022
ms.topic: article
ms.custom: intro-internal
---

# Roles and privileges associated with app profile manager

The following roles are available with the app profile manager:

- App Profile Manager Administrator
- App profile user

If your organization uses custom roles, and you want a user with the custom role to manage app profiles, then you can either assign the App Profile Manager Administrator role or manually add the privileges pertaining to the App Profile Manager Administrator role to the custom role.

## Roles for Customer Service workspace

By default, the privileges pertaining to the App Profile User role have been added to the Customer Service Representative and CSR Manager roles out of the box. You need to manually provide the App Profile Manager Administrator role to the user who will create app profiles, templates, productivity tools, and channel provider configurations.

## Roles for Omnichannel for Customer Service

Out of the box, for the Omnichannel administrator role, the privileges pertaining to the App Profile Manager Administrator role have been added, and for the Omnichannel agent and Omnichannel supervisor roles, the privileges pertaining to the App Profile User role have been added.

## Roles and their privileges

The actions and privileges for the roles in app profile manager are as follows.

### Role: App Profile Manager Administrator

The App Profile Manager Administrator has the following privileges.

| Action | Privileges|
|----|--------|
|Read/Append user|prvAppendUser <br>prvReadUser |
|Read/Assign role|prvAssignRole <br> prvReadRole |
|Read/Write/Create/Delete channel provider|prvWritemsdyn_channelprovider<br>prvReadmsdyn_channelprovider<br>prvDeletemsdyn_channelprovider<br> prvCreatemsdyn_channelprovider |
|Read/Write/Create/Delete/Append/Appendto application configuration|prvReadmsdyn_appconfiguration <br> prvWritemsdyn_appconfiguration<br> prvCreatemsdyn_appconfiguration <br>prvDeletemsdyn_appconfiguration <br> prvAppendmsdyn_appconfiguration<br> prvAppendTomsdyn_appconfiguration |
|Read/Write/Create/Delete/Append/Appendto application extension| prvCreatemsdyn_applicationextension <br> prvReadmsdyn_applicationextension <br>prvWritemsdyn_applicationextension <br> prvDeletemsdyn_applicationextension <br>prvAppendmsdyn_applicationextension<br> prvAppendTomsdyn_applicationextension |
|Read/Write/Create/Delete/Append/Appendto application tab template| prvReadmsdyn_applicationtabtemplate  <br> prvWritemsdyn_applicationtabtemplate <br> prvCreatemsdyn_applicationtabtemplate <br>prvDeletemsdyn_applicationtabtemplate<br> prvAppendmsdyn_applicationtabtemplate<br> prvAppendTomsdyn_applicationtabtemplate |
|Read/Write/Create/Delete/Append/Appendto notification field| prvReadmsdyn_notificationfield <br> prvCreatemsdyn_notificationfield <br> prvWritemsdyn_notificationfield <br> prvDeletemsdyn_notificationfield <br> prvAppendmsdyn_notificationfield <br> prvAppendTomsdyn_notificationfield |
|Read/Write/Create/Delete/Append/Appendto notification template| prvReadmsdyn_notificationtemplate <br> prvCreatemsdyn_notificationtemplate <br> prvWritemsdyn_notificationtemplate <br> prvDeletemsdyn_notificationtemplate <br> prvAppendmsdyn_notificationtemplate<br>prvAppendTomsdyn_notificationtemplate |
|Read/Write/Create/Delete/Append/Appendto session template| prvReadmsdyn_sessiontemplate<br> prvCreatemsdyn_sessiontemplate<br>prvWritemsdyn_sessiontemplate <br> prvDeletemsdyn_sessiontemplate <br> prvAppendmsdyn_sessiontemplate <br> prvAppendTomsdyn_sessiontemplate|
|Read/Write/Create/Delete/Append/Appendto template parameter| prvReadmsdyn_templateparameter<br> prvWritemsdyn_templateparameter<br> prvCreatemsdyn_templateparameter <br> prvDeletemsdyn_templateparameter <br>prvAppendmsdyn_templateparameter <br> prvAppendTomsdyn_templateparameter |
| Read/Write solution |  prvReadSolution<br>prvWriteSolution |
| Publish/Read/Write customization| prvPublishCustomization<br>prvReadCustomization<br>prvWriteCustomization  |
|Read/Write Query| prvReadQuery<br>prvWriteQuery |
|Read saved query visualizations| prvReadSavedQueryVisualizations |
|Read system form|prvReadSystemForm|
|Write entity|prvWriteEntity|
|Write attribute|prvWriteAttribute|
|Write relationship|prvWriteRelationship|
|Write/Read application module|prvWriteAppModule<br>prvReadAppModule  |
|| |

### Role: App Profile User

The App Profile User has the following privileges.

|Action|Privileges|
|-------|-----|
|Read application module|prvReadAppModule|
|Read channel provider| prvReadmsdyn_channelprovider|
|Read application configuration|prvReadmsdyn_appconfiguration |
|Read application extension| prvReadmsdyn_applicationextension |
|Read application tab template|prvReadmsdyn_applicationtabtemplate|
|Read notification field| prvReadmsdyn_notificationfield |
|Read notification template| prvReadmsdyn_notificationtemplate |
|Read session template|prvReadmsdyn_sessiontemplate|
|Read template parameter|prvReadmsdyn_templateparameter|
|Read user|prvReadUser |
|Read role|prvReadRole |
|| |

### See also

[An overview of app profile manager](overview.md)  
[Users and roles in Omnichannel for Customer Service](../customer-service/add-users-assign-roles.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
