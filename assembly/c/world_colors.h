#ifndef WORLD_COLORS_H
#define WORLD_COLORS_H

#include "color.h"

#define WORLD_COLOR_CONFIG_MAGIC 0x57524C44

struct world_color_config {
    u32 magic;
    u32 version;
    rgbs_t goronEnergyPunch;
    rgbs_t goronEnergyRolling;
    rgbs_t swordSlashEnergyBluePri;
    rgbs_t swordSlashEnergyRedPri;
    rgbs_t swordSlashEnergyEnv;
    rgbs_t swordSlashEnergyPri;
    rgbs_t blueBubble;
};

void WorldColors_Init(void);

#endif // WORLD_COLORS_H
