---
title: "Implement General Data Protection Regulation in portals for dynamics 365 | MicrosoftDocs"
description: "Learn about how to Implement General Data Protection Regulation in portals."
keywords: "portal GDPR, implement GDPR in portal"
ms.date: 01/26/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 61DDD947-32BC-4DA3-BDC1-6D1417412A6B
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Implement General Data Protection Regulation in portals

General Data Protection Regulation (GDPR) is a legal act of the European Union (EU), which protects data for all individuals within EU. With GDPR, the portal users can control the use of their personal data in Dynamics 365.

As an administrator, you can configure your portal to meet the GDPR standards. You can also provide certain terms and conditions for the portal users to use a portal. If a portal user is a minor, the user must have parental consent to use the portal. As a portal user, you must agree to the terms and conditions to use the portal.

Implementing GDPR allows obtaining consent from portal users regarding use of their personal data, identifying minor users, and obtaining parental consent for minor users.

## Audit logging

A field **Last logon** is added to the portal contact record for the evidence of when the portal user has last logged in. This date is picked-up by Dynamics 365 audit of the contact record and make that evidence available in the standard audit stream. This benefits the administrator to see the inactive community members and delete their records.

## Identify minor portal users and obtain parental consent

The identification of minor varies by country. A minor can access the portal with parental consent only. As an administrator, you can configure the portal to identify minors by using the following fields in the portal contact record:
- **Is Minor**: Indicates that the contact is considered a minor in their jurisdiction. By default, **No** is selected.
- **Is Minor with Parental Consent**: Indicates that the contact is considered a minor in their jurisdiction and has parental consent. By default, **No** is selected.

![Identify minor portal users and obtain parental consent](media/identify-minor-in-portal.png "Identify minor portal users and obtain parental consent")

### Related site settings

The following site settings control the use of portals by minors and minors without parental consent:

| Name  | Description   |
|-----------------------|------------------------------------------|
| Authentication/Registration/DenyMinors  | Denies use of the portal to minors. By default, it is set to false.                          |
| Authentication/Registration/DenyMinorsWithoutParentalConsent | Denies use of the portal to minors without parental consent. By default, it is set to false. |
|||

If a portal user is determined to be a minor and the portal is configured to block minors, an appropriate message is displayed, and the content is not displayed.

![Age requirements message](media/gdpr-age-req.png "Age requirements message")

If a portal user is determined to be a minor without parental consent and the portal is configured to block minors without parental consent, an appropriate message is displayed, and the content is not displayed.

![Parental consent message](media/gdpr-parental-consent.png "Parental consent message")

### Related content snippets

The following content snippets control the display of appropriate message on the screen when the portal is used by minors and minors without parental consent. You can change the message as per your requirement.

| Name                                                        | Type | Value                                                                    |
|-------------------------------------------------------------|------|--------------------------------------------------------------------------|
| Account/Signin/MinorNotAllowedHeading                       | Text | Age Requirements                                                         |
| Account/Signin/MinorNotAllowedCopy                          | HTML | The use of this portal is not suitable for use by minors is not allowed. |
| Account/Signin/MinorWithoutParentalConsentNotAllowedHeading | Text | Parental Consent                                                         |
| Account/Signin/MinorWithoutParentalConsentNotAllowedCopy    | HTML | The use of this portal by minors requires parental consent.              |
|||

When a portal user registers using an external provider and the portal is configured to block minors or minors without parental consent, the corresponding contact record is not created, and the user is not authenticated.

## Agreement to terms and conditions

As per GDPR, a portal user must agree to the terms and conditions to implement marketing, profiling, or access to private information about a data subject. As a portal administrator, you can publish your own terms and conditions to take consent of the portal user prior to being authenticated to the site.

![Portal terms and conditions](media/gdpr-terms-agreement.png "Portal terms and conditions")

### Related content snippets

The following content snippets control the display of terms and conditions on the screen. You can change the text as per your requirement.

| Name                                           | Type | Value                                 |
|------------------------------------------------|------|---------------------------------------|
| Account/Signin/TermsAndConditionsHeading       | Text | Terms and Conditions                  |
| Account/Signin/TermsAndConditionsCopy          | HTML |                                       |
| Account/Signin/TermsAndConditionsAgreementText | Text | I agree to these terms and conditions |
| Account/Signin/TermsAndConditionsButtonText    | Text | Continue                              |
|||

The `Account/Signin/TermsAndConditionsCopy` content snippet is empty by default. A portal administrator must enter the terms and conditions in this content snippet.

### Related site settings

The following site settings control the terms publication date and whether the terms should be displayed on the portal:

| Name                                              | Description                                                                                                                                                                                                                                                                                                                                                                                            |
|---------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/TermsPublicationDate  | A date/time value in GMT format to represent the effective date of the current published terms and conditions. If the terms agreement is enabled, portal users that have not accepted the terms after this date will be asked to accept them the next time they sign in. If the date is not provided, and the terms agreement is enabled, the terms will be presented every time portal users sign in. <br> **Note**: If you want a portal user to agree to the terms and conditions every time they sign in, do not provide a value for this site setting.|
| Authentication/Registration/TermsAgreementEnabled | A true or false value. If set to true, the portal will display the terms and conditions of the site. Users must agree to the terms and conditions before they are considered authenticated and can use the site. By default, it is set to false.                                                                                                                                                       |
|||

The following field is added in the portal contact record to store the date and time a portal user agreed to the terms and conditions:
- **Portal Terms Agreement Date**: Indicates the date and time that the person agreed to the portal terms and conditions.

    ![Portal Terms Agreement Date](media/portal-terms-agreement.png "Portal Terms Agreement Date")

## Integration with Dynamics 365 for Customer Insights

Dynamics 365 for Customer Insights (DCI) is a cloud-based SaaS service that enables organizations of all sizes to bring together data from multiple sources and generate knowledge and insights to build a holistic 360° view of their customers.

As a portal administrator, you can enable a portal to send data from a user’s activity to your DCI instance. More information: [View activity of a user on a portal](view-user-activity.md)

If a portal user is determined to be a minor or a minor with parental consent, the user’s activity is not sent to DCI. As an administrator, you can configure your portal whether to send the user’s activity to DCI by using the following field in the portal contact record:
- **Disable Web Tracking**: Indicates that the contact has opted out of web tracking. By default, **No** is selected.

    ![Image alt text](media/portal-disable-web-tracking.png "Image hover text")

> [!NOTE]
> You must configure DCI and enable [portal interaction tracking](view-user-activity.md) if the **Disable Web Tracking** field is set to **No**. You must also place this field on the profile form  to use this feature.

## Migrate identity providers to Azure AD B2C

Portal supports a configurable security system that enables our customers to support multiple authentication systems. The portal includes its own local credentials in addition to federating with external identity providers using standard protocols such as OIDC, SAML, and WS-Federation. Going forward, it is recommended to use only Azure AD B2C identity provider for authentication purpose and deprecate other identity providers.

### Mark an identity provider as deprecate

You can configure your portal to mark other identity providers as deprecated and allow users to migrate to Azure AD B2C identity provider. 

The following site settings are used to control the deprecation of identity providers:

| Name                                             | Description                                                                                                                                                                                        |
|--------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Authentication/Registration/LocalLoginDeprecated | A true or false value. If set to true, the local account will be marked as deprecated. The portal user will be required to migrate to a non-deprecated account. By default, it is set to false.    |
| Authentication/[protocol]/[provider]/Deprecated  | A true or false value. If set to true, the specific account will be marked as deprecated. The portal user will be required to migrate to a non-deprecated account. By default, it is set to false. |
|||

When a portal user tries to sign in, and you have marked at least one identity provider as deprecated, the deprecated account is displayed on the page. In the following example, Microsoft Account is marked as deprecated.

![Deprecated account example](media/gdpr-deprecate-account.png "Deprecated account example")

The text on the screen for legacy authentication provider can be changed by using the following content snippet:

| Name                                               | Type | Value                         |
|----------------------------------------------------|------|-------------------------------|
| Account/Signin/SignInExternalDeprecatedFormHeading | Text | Sign in with a legacy account |
|||

> [!NOTE]
> The deprecated identity providers are not displayed when a user registers or redeems invitation for a portal.

### Migrate deprecated identity provider to a new identity provider

If a portal user signs in with a deprecated identity provider, the account migration screen is displayed with a message to sign in with a non-deprecated identity provider. When the user signs in with the non-deprecated identity provider, the user account is associated with the new provider.

![Account migration example](media/gdpr-account-migration.png "Account migration example")

The text on the screen for account migration can be changed by using the following content snippets:

| Name                                         | Type | Value                                                                                                                                                                                                                |
|----------------------------------------------|------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Account/Conversion/PageTitle                 | Text | Account Migration                                                                                                                                                                                                    |
| Account/Conversion/PageCopy                  | HTML | You have signed in with an account that is no longer supported. To continue using this portal, you must migrate to a different account. Select the button below to sign in with a new or existing supported account. |
| Account/Conversion/SignInExternalFormHeading | Text | Sign in with a supported account                                                                                                                                                                                     |
|||

Portal supports multiple identities to be associated to a single contact record. When multiple providers are deprecated, a portal user must provide consent to the terms multiple times. Whenever a user signs in with a deprecated identity provider, the account migration process is initiated for each deprecated provider and the contact record is associated to the non-deprecated provider after account migration.

For example:  Portal supports Microsoft Account (MSA), Google, and Facebook as the identity providers for authentication. As an administrator, you mark Google and Facebook as deprecated providers. A portal user has Google and Facebook only as the identity providers for authentication. The user signs in to the portal for the first time using Google. The portal identifies Google as a deprecated provider and displays the message for account migration. The user signs in using MSA, as it is the only non-deprecated provider. As a result, Google is disabled and MSA is added as external identity provider to the user’s contact record. The portal user now signs in to the portal using Facebook. As Facebook is also marked as deprecated, the account migration process is initiated and the user signs in using MSA. As a result, Facebook is disabled and MSA is added as external identity provider to the user’s contact record. The user now has only MSA as the supported authentication mechanism.

When a portal user selects a new identity provider in the account migration process and the identity is already associated with another contact record, an error is displayed. As an administrator, you can configure the error message by using the following content snippets:

| Name                                                     | Type | Value                                                                                                                               |
|----------------------------------------------------------|------|-------------------------------------------------------------------------------------------------------------------------------------|
| Account/Signin/AccountConversionIdentityUsedErrorHeading | Text | Account Conversion Error                                                                                                            |
| Account/Signin/AccountConversionIdentityUsedErrorText    | HTML | This account already exists. Close your browser, restart the process, and select a different account on the Account Migration page. |
|||

### Disable local login

As an administrator, you can configure a portal to disable the local login by using the `Authentication/Registration/LocalLoginDeprecated` site setting. If a portal user tries to sign in by using the local credentials, the account migration screen is displayed with the instruction to sign in with a non-deprecated identity provider. When the account is migrated, the local credentials for the user are disabled.

> [!NOTE]
> If you mark the local login as deprecated, the user will not be able to register for a new account.

The following field is added in the portal contact record to indicate if the local login is disabled for a user:
- **Local Login Disabled**: Indicates that the contact can no longer sign in to the portal using the local account. By default, it is set to **No**. This field is set to **Yes** if a user’s account is migrated to a non-deprecated identity provider and local login is disabled.

    ![Local login disabled](media/local-login-disabled.png "Local login disabled")
