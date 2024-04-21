# Basionix Base Entities

Base classes and interfaces for applications done in C#, so you don't have to create them by hand on every single project you start.

- IEntity<TKey>
- BaseEntity<TKey>
- ITenantEntity<TKey, TTenantKey>
- BaseTenantEntity<TKey, TTenantKey>
- IAuditableEntity<TUserValue> (CreatedAt, UpdatedAt, CreatedBy<TUserValue>, LastUpdatedBy<TUserValue>)
- ISoftDeletable<TKey,TUserValue> (With IsDeleted, DeletedAt, DeletedBy<T>)
- BaseSoftDeletable<TKey,TUserValue>
- IDateTimeProvider
- BaseDateTimeProvider (Returning UTC DateTime/DateTimeOffset)
