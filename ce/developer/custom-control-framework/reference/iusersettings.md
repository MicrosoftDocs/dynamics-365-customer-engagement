# IUserSettings

[!INCLUDE [cc_applies_to_update_9_0_0](../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE [iusersettings-description](includes/iusersettings-description.md)]

## dateFormattingInfo

Date formatting information as retrieved from the server.

**Type**: `DateFormattingInfo`

**Required**: yes

## isHighContrastEnabled

Whether High Contrast is enabled.

**Type**: `boolean`

**Required**: yes

## isRTL

Whether the language is right to left

**Type**: `boolean`

**Required**: yes

## languageId

Current user's language id

**Type**: `number`

**Required**: yes

## numberFormattingInfo

Number formatting information as retrieved from the server.

**Type**: `NumberFormattingInfo`

**Required**: yes

## pagingLimit

Returns the paging limit of the user

**Type**: `number`

**Required**: yes

## securityRoles

Current user roles

**Type**: `string[]`

**Required**: yes

## userId

The id of the current user

**Type**: `string`

**Required**: yes

## userName

The name of the current user

**Type**: `string`

**Required**: yes



## Methods

|Method | Description | 
| ------|-------------|
|[getTimeZoneOffsetMinutes](iusersettings/gettimezoneoffsetminutes.md)|[!INCLUDE [gettimezoneoffsetminutes-description](iusersettings/includes/gettimezoneoffsetminutes-description.md)]|