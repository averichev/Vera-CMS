alter table "AspNetUsers"
    alter column "EmailConfirmed" type boolean using "EmailConfirmed"::boolean