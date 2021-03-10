create table "Site"
(
    "Id"       serial  not null
        constraint site_pk
            primary key,
    "Protocol" varchar not null,
    "Host"     varchar not null
);

create unique index site__protocol_host_unique_pair
    on "Site" ("Protocol", "Host");

create unique index site_host_uindex
    on "Site" ("Host");