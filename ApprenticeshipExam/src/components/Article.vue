<script setup lang="ts">
import { defineProps } from "vue";

const props = defineProps({
  image: String,
  title: String,
  ingress: String,
  content: String,
});
</script>

<template>
  <div class="grid grid-cols-3">
    <div class="col-span-2 px-4  max-w-3xl">
      <div class="flex flex-col text-2xl font-bold">
        {{ title }}
      </div>
      <div class="border-b-2 border-gray-400 mb-6">
        {{ingress}}
      </div>
      <slot name="content" class="">
        {{ content }}
      </slot>
    </div>
    <img :src="image" alt="img" class="rounded-lg w-full px-4" />
  </div>

</template>
