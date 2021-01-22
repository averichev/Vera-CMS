alter table "AspNetUsers"
    alter column "LockoutEnabled" type boolean using "LockoutEnabled"::boolean