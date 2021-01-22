alter table "AspNetUsers"
    alter column "PhoneNumberConfirmed" type boolean using "PhoneNumberConfirmed"::boolean;
alter table "AspNetUsers"
    alter column "TwoFactorEnabled" type boolean using "TwoFactorEnabled"::boolean;
