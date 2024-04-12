<template>
    <div class="booking">
        <h1 class="text-center">Välkommen till Fotbollshörnan</h1>
        <h2>Här kan du skapa intresseanmälningar för fotbollsevenemang samt kommunicera med andra fotbollsentusiaster</h2>
        <div class="container">
            <div class="row">
                <div class="col">
                    <div class="card" style="width: 18rem;">
                        <ul class="list-group list-group-flush">
                            <li class="list-group-item">Antal deltagare: 1</li>
                            <li class="list-group-item">Tid: 18:00</li>
                            <li class="list-group-item">Plats: Konstgräsplanen IP</li>
                        </ul>
                        <div class="card-footer">
                            <button class="btn btn-primary">Gå med</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'SoccerView',
  components: {
  },
});

</script>
