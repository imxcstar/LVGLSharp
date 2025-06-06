cd lvgl

if not exist build (
    mkdir build
)

cd build

cmake -DCONFIG_LV_BUILD_EXAMPLES=OFF -DCONFIG_LV_BUILD_DEMOS=OFF -DCONFIG_LV_USE_THORVG_INTERNAL=OFF -DBUILD_SHARED_LIBS=OFF -DCONFIG_LV_USE_PRIVATE_API=ON ..

cmake --build . --config Release