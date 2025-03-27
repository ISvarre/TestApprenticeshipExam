<script setup lang="ts">
import { defineProps } from "vue";

const props = defineProps({
  image: String,
  title: String,
  location: String,
  tag: String
});
</script>

<template>
  <div
    class="flex flex-col items-center bg-white rounded-lg shadow-lg overflow-hidden hover:shadow-xl transition-shadow duration-300"
  >
    <img
      :src="image"
      alt="Destination Image"
      class="w-full h-40 object-cover"
    />
    <div class="p-4 text-center">
      <span
        class="inline-block bg-red-500 text-white text-xs font-semibold py-1 px-3 rounded-full mb-2"
      >
        {{ tag }}
      </span>
      <h3 class="text-lg font-bold text-gray-800">
        {{ title }}
      </h3>
      <p class="text-sm text-gray-600">
        {{ location }}
      </p>
    </div>
  </div>
</template>
