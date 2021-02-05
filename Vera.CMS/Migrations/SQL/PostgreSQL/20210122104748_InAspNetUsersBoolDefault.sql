alter table "AspNetUsers"
    alter column "LockoutEnabled" set default false;
alter table "AspNetUsers"
    alter column "EmailConfirmed" set default false;
alter table "AspNetUsers"
    alter column "TwoFactorEnabled" set default false;