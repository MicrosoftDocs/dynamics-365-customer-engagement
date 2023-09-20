---
title: App shows error on start due to Permissions and Privileges Issues
description: FSM App (preview) shows error on start due to Permissions and Privileges Issues
ms.date: 09/14/2023
ms.topic: troubleshooting
author: andrea-orimoto
ms.author: andreo
ms.reviewer: 
ms.custom: bap-template
---

Michael the content for [this page is here](https://dynamicscrm.visualstudio.com/OneCRM/_wiki/wikis/FieldService.NativeExperience/65417/Permissions-and-Privileges-Issue-prvReadmsdyn_Mobile)

1. summarize as needed
2. clean up screenshots (names, etc.)
1. 

#App crashes due to Permissions and Privileges Issues

##Summary of the error condition
The FSM app fails to launch with an error similar to the following:

`Principal user (Id=<GUID>, …) is missing 'prvReadmsdyn_Mobile' privilege (Id=<GUID>) on OTC=<INT> for entity 'msdyn_mobilesource' …`


##Reason for the error
The Public Preview of the new FSM Native UX requires a few additional privileges added to the Security Roles which the user belongs to. We automatically add these new privileges to all Out Of The Box Security Roles. If you are using a custom Security Role then you might need to update it by adding these additional privileges:

- Name=`"msdyn_richtextfile"` Permission="Create" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Delete" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Read" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Write" Value="User"
- Name=`"msdyn_MobileSource"` Permission="Read" Value="Organization"
- Name=`"msdyn_solutioncomponentsummary"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"
- Name=`"Solution"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"

##Steps to solve (Admin account required)
1. Go to `https://admin.powerplatform.microsoft.com/`
2. Login with Admin account credentials.

![Screenshot 2023-09-11 at 9.01.20 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.01.20%20PM-308fc0fc-65be-4a60-805b-362dbe2e3243.png =300x300)

3. On the left menu, click on `Environments`.
4. Find the environment to update user permissions.

![Screenshot 2023-09-11 at 9.07.30 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.07.30%20PM-ea15275a-e3e2-4d7e-b1cd-903ebda64e8d.png)

5. Click on the ellipsis next to the Environment name and select `Settings`.

![Screenshot 2023-09-11 at 9.10.57 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.10.57%20PM-8327a7c2-8af5-4cee-9a45-c35d9764e569.png)

6. Open **Users + permissions** section.
7. If you know the Custom Security Role you need to update, jump to step **#12**. If not, find the Custom Security Role(s) name(s) in the User record. Click on `Users`.

![Screenshot 2023-09-12 at 10.41.14 AM.png](/.attachments/Screenshot%202023-09-12%20at%2010.41.14%20AM-1f630119-39d8-4cdf-b6c2-9f6729fb4f7e.png)

8. Find the user that is experiencing the problem.
9. Review and **take note** on the current security roles under `Roles` 

![Screenshot 2023-09-12 at 10.42.52 AM.png](/.attachments/Screenshot%202023-09-12%20at%2010.42.52%20AM-a707ccd9-b6cb-4e5f-90ce-6c2ffedb9c3d.png)

10. Close the modal.
11. On the Users page, click on `Settings` to go back to Settings page.

![Screenshot 2023-09-12 at 10.54.41 AM.png](/.attachments/Screenshot%202023-09-12%20at%2010.54.41%20AM-9c26c376-a13b-4cda-af23-4d0b7a499384.png)

12. Under **Users + permissions** section. Click on `Security roles`

![Screenshot 2023-09-11 at 9.12.25 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.12.25%20PM-81f4213b-d7df-4931-bf9e-0f1cd879a46b.png)

13. For all the Custom Security Roles you found in step **#9**, do the following steps. In this example, we are using the `Field Service - Resource` role.

![Screenshot 2023-09-11 at 9.18.18 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.18.18%20PM-6ac2e756-fdb5-4522-bc4e-ce1e584fe443.png)

14. Click on dropdown to `Show all tables` under the `Tables` tab.

![Screenshot 2023-09-12 at 10.44.56 AM.png](/.attachments/Screenshot%202023-09-12%20at%2010.44.56%20AM-ecc1eb59-6b15-4c1d-9387-e707ac78259f.png)

15. For all the privileges in this list, make sure that its value is set accordingly.
###Field Services Mobile Native Permissions 
- Name=`"msdyn_richtextfile"` Permission="Create" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Delete" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Read" Value="User"
- Name=`"msdyn_richtextfile"` Permission="Write" Value="User"
- Name=`"msdyn_MobileSource"` Permission="Read" Value="Organization"
- Name=`"msdyn_solutioncomponentsummary"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"
- Name=`"Solution"` Permission="Read" Value="Organization"
- Name=`"SettingDefinition"` Permission="Read" Value="Organization"

For example: 
- Name: `msdyn_MobileSource` search for: `MobileSource`
- Name: `msdyn_richtextfile` search for: `richtextfile`

![Screenshot 2023-09-11 at 9.20.49 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.20.49%20PM-12fe8a14-a217-49d1-b1c8-3ec785ec7b76.png)

16. Once you find the privilege, update its value. For example:
- Privilege: `"Create"` with Value: `"User"`. Go to the column that shows "Create" and change the dropdown to the value needed that in this case is `"User"`.

![Screenshot 2023-09-11 at 9.22.37 PM.png](/.attachments/Screenshot%202023-09-11%20at%209.22.37%20PM-59a57371-78f9-4cf5-a228-64c1e6c644ca.png)

17. Once all the Security Roles have been updated the error condition should stop occurring. 